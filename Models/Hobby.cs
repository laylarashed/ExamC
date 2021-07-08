using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BeltExam.Models
{
    public class Hobby
    {
        
        [Key]
        public int HobbyId { get; set; }
       
        public int UserId { get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "Name : ")]
        public string Name { get; set; }



        [Required]
        [MinLength(5)]
        [Display(Name = "Description : ")]
        public string Description { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public User Createdby { get; set; }
        public List<Enthusiast> HobbyEnthusiast { get; set; }


    }
}