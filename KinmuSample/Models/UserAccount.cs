using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace KinmuSample.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID {get; set;}
        [Required(ErrorMessage = "Username is required")]
        public string UserName{get; set;}
        
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password{get; set;}

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:dd/MM/yyyy}")]
        //public string RegisterDate { get; set; }
    }
}