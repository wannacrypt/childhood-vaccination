using System;
namespace ChildhoodVaccination.Models
{
    public class TicketVaccine
    {
        public string ID_ticket { get; set; }
        public string ID_vaccine_schedule { get; set; }
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
