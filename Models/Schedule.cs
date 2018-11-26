using System;
namespace Playground.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int DoctorID { get; set; }
        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public bool Evening { get; set; }
    }
}
