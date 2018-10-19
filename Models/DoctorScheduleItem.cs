using System;
namespace ChildhoodVaccination.Models
{
    public class DoctorScheduleItem
    {
        public string ID_item { get; set; }
        public string ID_schedule { get; set; }
        public DateTime Date { get; set; }
        public int Room { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeFinish { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public DoctorScheduleItem()
        {
        }
    }
}
