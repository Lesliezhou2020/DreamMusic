using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamMusic.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Display(Name="Name: ", Prompt="Enter your Name here")]
        [Required]
        [MinLength(2, ErrorMessage="Name must be 2 characters or longer!")]
        public string Name {get;set;}

        [Display(Name="Email: ")]
        [Required(ErrorMessage="Email address is required.")]
            // [EmailAddress]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage="Invalid email address.")]
        public string Email {get;set;}

        [DataType(DataType.Password)]
        [Required]
        //[MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [RegularExpression(@"((?=.*\d)(?=.*[A-Za-z])(?=.*\W).{8,})",
            ErrorMessage="Password must be at least 8 characters and contain 1 number, 1 letter, and 1 special character")]
        public string Password {get;set;}

        
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        // Navigation properties
        public List<DrumSheet> DrumSheets {get; set;}
        public List<Like> Likes {get; set;}
    } 
}
