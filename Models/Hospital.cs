using System;
using System.ComponentModel.DataAnnotations;

namespace ChildhoodVaccination.Models
{
    public class Hospital
    {
        [Key]
        public long HospitalID { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Hospital()
        {
        }
    }
}
