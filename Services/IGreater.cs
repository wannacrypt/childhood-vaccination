using Microsoft.Extensions.Configuration;

namespace ChildhoodVaccination.Services
{
    public interface IGreater {
        string GetMessageOfTheDay();
    }

    public class GreatingService : IGreater 
    {
        private IConfiguration _configuration;
        public GreatingService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessageOfTheDay() 
        {
            return _configuration["Greeting"];
        }
    }

}