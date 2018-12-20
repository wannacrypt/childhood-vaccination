using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playground.Models
{
    public class Prescription
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int ChildId { get; set; }
        [Required]
        public int Room { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public string DoctorFullName { get; set; }
        [Required]
        public string Diagnosis { get; set; }
        [Required]
        public string VisitType { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string PrescriptionText { get; set; }
    }
}
