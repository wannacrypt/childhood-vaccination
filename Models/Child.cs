
using System;

namespace ChildhoodVaccination.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string DOB { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}