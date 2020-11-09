using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DreamMusic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace DreamMusic.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private Random rnd;
        
        public HomeController(MyContext context)
        {
            _context = context;
            rnd = new Random();
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            int? active_user_id = HttpContext.Session.GetInt32("active_user");
            if (!active_user_id.HasValue)
            {
                active_user_id = -1;
            }

            DrumSheet random = new DrumSheet {
                Crash      = generate(16),
                Ride       = generate(16),
                FloorTom   = generate(16),
                MidTom     = generate(16),
                HighTom    = generate(16),
                Kick       = generate(16),
                Snare      = generate(16),
                HiHatOpen  = generate(16),
                HiHatClose = generate(16),
            };
            ViewBag.sheet = random;

            User guest = new User {
                UserId = -1
            };

            var user = _context.Users.FirstOrDefault(u => u.UserId == active_user_id.Value);
            ViewBag.user = user == null? guest : user;
            
            var toplist = _context.DrumSheets.Include(c => c.Likes)
                .OrderByDescending(c => c.Likes.Count)
                .Take(10);
            
            ViewBag.toplist = toplist;
            return View();
        }

        [HttpGet("sign")]
        public IActionResult Sign()
        {
            Login_Register_wrapper wrapper = new Login_Register_wrapper();
            return View("Sign", wrapper);
        }

        [HttpPost("process_register")]
        public IActionResult Process_Register(User FromForm)
        {
            Login_Register_wrapper wrapper=new Login_Register_wrapper();
            if(ModelState.IsValid)
            {
                if(_context.Users.FirstOrDefault(u => u.Email == FromForm.Email) != null)
                {
                    ModelState.AddModelError("Email", "Email already registered here");
                    return View("Sign", wrapper);
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                FromForm.Password = Hasher.HashPassword(FromForm, FromForm.Password);
                _context.Add(FromForm);
                _context.SaveChanges();
                var user = _context.Users.FirstOrDefault(u => u.Email == FromForm.Email);
                HttpContext.Session.SetInt32("active_user", user.UserId);
                return RedirectToAction("Index");
            }
            return View("Sign", wrapper);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser FromForm)
        {
            Login_Register_wrapper wrapper = new Login_Register_wrapper();
            if (ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == FromForm.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email");
                    return View("Sign", wrapper);
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(FromForm, userInDb.Password, FromForm.LoginPassword);
                
                if(result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Password");
                    return View("Sign", wrapper);
                }
                HttpContext.Session.SetInt32("active_user", userInDb.UserId);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.SetInt32("active_user", -1);
            return RedirectToAction("Index");
        }

        [HttpPost("new")]
        public JsonResult New(DrumSheet data)
        {
            _context.Add(data);
            _context.SaveChanges();
            return Json(data);
        }

        [HttpGet("all")]
        public IActionResult AllBeats()
        {
            int? active_user_id = HttpContext.Session.GetInt32("active_user");
            if (!active_user_id.HasValue)
            {
                active_user_id = -1;
            }
            
            User guest = new User {
                UserId = -1
            };

            var user = _context.Users.FirstOrDefault(u => u.UserId == active_user_id.Value);
            ViewBag.user = user == null? guest : user;
            ViewBag.AllBeats = _context.DrumSheets
                .Include(d => d.Creator)
                .Include(d => d.Likes)
                .OrderByDescending(d => d.Likes.Count);
            return View("AllBeats");
        }

        [HttpGet("detail/{sheetId}")]
        public IActionResult Detail(int sheetId)
        {
            int? active_user_id = HttpContext.Session.GetInt32("active_user");
            if (!active_user_id.HasValue)
            {
                active_user_id = -1;
            }
            
            User guest = new User {
                UserId = -1
            };

            var user = _context.Users.FirstOrDefault(u => u.UserId == active_user_id.Value);
            ViewBag.user = user == null? guest : user;

            var sheet = _context.DrumSheets
                .Include(d => d.Creator)
                .Include(d => d.Likes)
                .FirstOrDefault(d => d.SheetId == sheetId);
            if (sheet == null)
            {
                return RedirectToAction("Index");
            }
            return View("Detail", sheet);
        }

        [HttpPost("update")]
        public IActionResult Update(DrumSheet fromForm)
        {
            _context.Update(fromForm);
            _context.Entry(fromForm).Property("CreatedAt").IsModified = false;
            _context.SaveChanges();
            return RedirectToAction("Detail", new { sheetId = fromForm.SheetId });
        }

        [HttpGet("delete/{sheetId}")]
        public IActionResult Delete(int sheetId)
        {
            int? active_user_id = HttpContext.Session.GetInt32("active_user");
            if (active_user_id.HasValue && active_user_id != -1)
            {
                var sheet = _context.DrumSheets.FirstOrDefault(d => d.SheetId == sheetId);
                if (sheet != null && sheet.CreatorId == active_user_id) {
                    _context.DrumSheets.Remove(sheet);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet("like/{sheetId}")]
        public IActionResult Like(int sheetId)
        {
            int ? active_user = HttpContext.Session.GetInt32("active_user");
            if (active_user.HasValue && active_user != -1)
            {
                Like like = new Like();
                like.SheetId = sheetId;
                like.UserId = active_user.Value;
                _context.Likes.Add(like);
                _context.SaveChanges();
                return RedirectToAction("Detail", new { sheetId = sheetId });
            }
            return RedirectToAction("Sign");
        }

        [HttpGet("unlike/{sheetId}")]
        public IActionResult Unlike(int sheetId)
        {
            int ? active_user = HttpContext.Session.GetInt32("active_user");
            if (active_user.HasValue && active_user != -1)
            {
                var like = _context.Likes
                    .FirstOrDefault(l => l.UserId == active_user.Value && l.SheetId == sheetId);
                if (like != null) {
                    _context.Likes.Remove(like);
                    _context.SaveChanges();
                }
                return RedirectToAction("Detail", new { sheetId = sheetId });
            }
            return RedirectToAction("Sign");
        }

        private string generate(int length)
        {
            var stringChars = new char[length];
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = rnd.Next(2) == 0 ? 'x' : '-';
            }
            return new string(stringChars);
        }
    }
}