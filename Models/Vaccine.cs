using System;
namespace ChildhoodVaccination.Models
{
    public class Vaccine
    {
        public string Name { get; set; }
        public string ID_vaccine_schedule { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string ID_vaccine { get; set; }
        public string ID_schedule { get; set; }
        public string NameVaccine { get; set; }
        public string PostCareDescription { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; set; }
        public DateTime VaccineCreated { get; set; }
        public DateTime VaccineUpdated { get; set; }

        public Vaccine()
        {
        }
    }
}
