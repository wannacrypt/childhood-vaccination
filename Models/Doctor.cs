using System;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
    }
}
