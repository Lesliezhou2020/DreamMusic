using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamMusic.Models
{
    public class Like
    {
        [Key]
        public int Id {get; set;}

        // Navigation properties
        public int UserId {get; set;}
        public int SheetId {get; set;}
        public User User {get; set;}
        public DrumSheet Sheet {get; set;}
    }
}