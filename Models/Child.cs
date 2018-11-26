using System;
using System.ComponentModel.DataAnnotations;
namespace Playground.Models
{
    public class Child
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string IIN { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(20)]
        public string Phone { get; set; }

        [Required, Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
