using System;
using System.ComponentModel.DataAnnotations;

namespace ChildhoodVaccination.Models
{
    public class Child
    {
        [Key]
        public long ChildID { get; set;  }
        public long DoctorID { get; set; }
        public long HospitalID { get; set; }
        public long ScheduleID { get; set; }
        [Required]
        public string IIN { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Paternity { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Byte[] Photo { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}