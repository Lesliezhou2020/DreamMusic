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
                HttpContext.Session.SetInt32("active_user", -1);
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
            ViewBag.userId = active_user_id.HasValue ? active_user_id.Value : -1;
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