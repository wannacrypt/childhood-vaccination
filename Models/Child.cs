using System;

namespace ChildhoodVaccination.Models
{
    public class Child
    {
        public long ID { get; set;  }
        public string IIN { get; set; }
        public string ID_doctor { get; set; }
        public string ID_hospital { get; set; }
        public string ID_schedule { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Paternity { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime BirthDate { get; set; }
        public Byte[] Photo { get; set; }
    }
}