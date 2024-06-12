using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models

{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
        public string login { get; set; }
        public bool IsDeleted { get; set; }
    }
}
