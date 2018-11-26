using Microsoft.Extensions.Configuration;

namespace Playground.Services
{
    public interface IGreetingService
    {
        string GetGreetingMessage();
        string GetErrorMessage();
        void SetUser(string name);
        string GetUser();
    }

    public class Greeter : IGreetingService
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetGreetingMessage()
        {
            return _configuration["Greeting"];
        }

        public void SetUser(string name)
        {
            _configuration["User"] = name;
        }

        public string GetUser()
        {
            return _configuration["User"];
        }

        public string GetErrorMessage()
        {
            return _configuration["Error"];
        }
    }
}