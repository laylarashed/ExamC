using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BeltExam.Models
{
    public class Enthusiast
    {
        
        [Key]
        public int EnthusiastId { get; set; }
        public int HobbyId { get; set; }
        public int UserId { get; set; }
        public string Proficiency { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public Hobby EnthusiastHobby { get; set; }
        public User EnthusiastUser { get; set; }



    }
}