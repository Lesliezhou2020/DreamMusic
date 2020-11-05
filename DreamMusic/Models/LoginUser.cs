using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamMusic.Models 
{
    public class LoginUser
    {
        // No other fields!
        public string LoginEmail {get; set;}
        public string LoginPassword { get; set; }
    }

}