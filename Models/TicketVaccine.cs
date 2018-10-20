using System;
using System.ComponentModel.DataAnnotations;

namespace ChildhoodVaccination.Models
{
    public class TicketVaccine
    {
        [Key]
        public string TicketVaccineID { get; set; }
        public string VaccineScheduleID { get; set; }
        public string TicketName { get; set; }
        public DateTime TicketDate { get; set; }
        public int Room { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string ID_nurse { get; set; }

        public TicketVaccine()
        {
        }
    }
}
