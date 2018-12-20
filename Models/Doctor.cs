using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public List<Ticket> Tickets { get; set; }
    }
}
