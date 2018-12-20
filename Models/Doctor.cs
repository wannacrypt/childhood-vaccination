using System;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Login { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
    }
}
