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
        
        public HomeController(MyContext context)
        {
            _context = context;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            string defaultBeats = "xxx-x--xxx--xx--xx---xxx-x-xxx--x-xx";
            ViewBag.beats = defaultBeats;
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

        [HttpGet("new")]
        public IActionResult Compose()
        {
            return View("Compose");
        }
    }
}