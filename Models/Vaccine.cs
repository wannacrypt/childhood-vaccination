using System;
using System.ComponentModel.DataAnnotations;

namespace ChildhoodVaccination.Models
{
    public class Vaccine
    {
        [Key]
        public long VaccineID { get; set; }
        public long VaccineScheduleID { get; set; }
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string PostCareDescription { get; set; }
        public short Age { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Vaccine()
        {
        }
    }
}
