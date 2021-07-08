using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BeltExam.Models
{
    public class User
    {
        
        [Key]
        public int UserId { get; set; }


        [Required]
        [Display(Name = "First Name : ")]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [MinLength(2, ErrorMessage = "The First Name must be at least 8 charchters")]
        public string FirstName { get; set; }


        [Required]
        [Display(Name = "Last Name : ")]
        [RegularExpression(@"^[a-zA-Z""'\s-]*$")]
        [MinLength(2, ErrorMessage = "The Last Name must be at least 8 charchters")]
        public string LastName { get; set; }



        [Required]
        [Display(Name = "User Name : ")]
        [MinLength(3, ErrorMessage = "The UserName must be at least 3 charchters")]
        [MaxLength(15, ErrorMessage = "The UserName must be at maximum 15 charchters")]
        public string Username { get; set; }



        [Required]
        [Display(Name = "Password : ")]
        [MinLength(8, ErrorMessage = "The password must be at least 8 charchters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage="This message for you Mr.Jason to make your Password more secure , and the Password must contain at least 1 lowercase, 1 uppercase, 1 number, and 1 special character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        [NotMapped]
        [Required]
        [Display(Name = "Password Confirm : ")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }
        public List<Hobby> Creator { get; set; }
        public List<Enthusiast> UserEnthusiast { get; set; }


    }
}