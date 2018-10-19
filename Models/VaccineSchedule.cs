using System;
namespace ChildhoodVaccination.Models
{
    public class VaccineSchedule
    {
        public string Name { get; set; }
        public string ID_vaccine_schedule  { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public VaccineSchedule()
        {
        } 
    }
}
