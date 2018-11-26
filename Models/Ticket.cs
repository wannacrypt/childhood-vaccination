using System;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public int Room { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
        public int DoctorId { get; set; }
    }
}
