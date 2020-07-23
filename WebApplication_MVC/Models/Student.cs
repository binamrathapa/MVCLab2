using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_MVC.Models
{
    public class Student
    {
        public int Id
        {
            get;set;
        }
        [Required(ErrorMessage ="Name is required")]
        public string Name
        { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email
        { get; set; }
        public string Address
        { get; set; }
    }
}