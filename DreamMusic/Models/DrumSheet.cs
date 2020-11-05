using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DreamMusic.Models
{
    public class DrumSheet
    {
        [Key]
        public int SheetId {get; set;}

        [Required]
        [MinLength(2, ErrorMessage="Title must be 2 characters or longer")]
        public string Title {get; set;}

        public string Beats {get; set;}

        // Navigation attribute
        public int CreatorId {get; set;}
        public User Creator {get; set;}
        // Many to Many navigation attribute
        public List<Like> Likes {get; set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}