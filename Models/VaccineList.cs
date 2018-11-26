using System;
using System.ComponentModel.DataAnnotations;

namespace Playground.Models
{
    public class VaccineList
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string VaccineName { get; set; }
        public bool Status { get; set; }
        public int DoctorId { get; set; }
        public int PrescriptionId { get; set; }
        public int NurseId { get; set; }
        public TimeSpan Time { get; set; }
        public int Room { get; set; }
    }
}
