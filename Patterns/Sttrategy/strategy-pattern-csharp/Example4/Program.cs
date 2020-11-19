using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    public class Program
    {
        public interface ICommunicateInterface
        {
            string Communicate(string destination);
        }

        public class CommunicateViaPhone : ICommunicateInterface
        {
            public string Communicate(string destination)
            {
                return "communicating " + destination + " via Phone..";
            }
        }

        public class CommunicateViaEmail : ICommunicateInterface
        {
            public string Communicate(string destination)
            {
                return "communicating " + destination + " via Email..";
            }
        }

        public class CommunicateViaVideo : ICommunicateInterface
        {
            public string Communicate(string destination)
            {
                return "communicating " + destination + " via Video..";
            }
        }

        public class CommunicationService
        {
            private Func<string, string> communcationMeans;
            public void SetCommuncationMeans(Func<string, string> communcationMeans)
            {
                this.communcationMeans = communcationMeans;
            }
            public void Communicate(string destination)
            {
                var communicate = communcationMeans(destination);
                Console.WriteLine(communicate);
            }
        }

        static void Main(string[] args)
        {
            string communicateViaEmail(string destination) => "communicating " + destination + " via Email..";
            string communicateViaPhone(string destination) => "communicating " + destination + " via Phone..";
           

            CommunicationService communicationService = new CommunicationService();
            // via phone
            communicationService.SetCommuncationMeans(communicateViaPhone);
            communicationService.Communicate("1234567");
            // via email
            communicationService.SetCommuncationMeans(communicateViaEmail);
            communicationService.Communicate("hi@me.com");
            //via Video
            communicationService.SetCommuncationMeans((string destination) => "communicating " + destination + " via Video..");
            communicationService.Communicate("1234567");

            Console.ReadLine();

        }
    }
}
