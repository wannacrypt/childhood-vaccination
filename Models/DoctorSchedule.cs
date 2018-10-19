using System;
namespace ChildhoodVaccination.Models
{
    public class DoctorSchedule
    {
        public string ID_schedule { get; set; }
        public string ID_doctor { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public DoctorSchedule()
        {
        }
    }
}
