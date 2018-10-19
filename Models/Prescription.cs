using System;
namespace ChildhoodVaccination.Models
{
    public class Prescription
    {
        public string ID_prescription { get; set; }
        public string ID_doctor { get; set; }
        public string ID_child { get; set; }
        public DateTime Date { get; set; }
        public DateTime Diagnosis { get; set; }
        public string Description { get; set; }
        public string PrescriptionP { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Prescription()
        {
        }
    }
}
