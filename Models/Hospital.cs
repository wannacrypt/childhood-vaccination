using System;
namespace ChildhoodVaccination.Models
{
    public class Hospital
    {
        public string Id_hospital { get; set; }
        public string HospitalName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Hospital()
        {
        }
    }
}
