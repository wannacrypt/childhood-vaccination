using System;
namespace ChildhoodVaccination.Models
{
    public class Nurse
    {
        public string ID_nurse { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ID_doctor { get; set; }
        public Byte[] Photo { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Nurse()
        {
        }
    }
}
