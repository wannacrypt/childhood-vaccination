using System;
namespace ChildhoodVaccination.Models
{
    public class TicketDoctor
    {
        public string ID_ticket { get; set; }
        public string ID_schedule { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Room { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public TicketDoctor()
        {
        }
    }
}
