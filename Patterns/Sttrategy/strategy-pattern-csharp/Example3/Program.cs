using System;
using System.Collections.Generic;
using System.Linq;

namespace Example3
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
            private ICommunicateInterface communcationMeans;
            public void SetCommuncationMeans(ICommunicateInterface communcationMeans)
            {
                this.communcationMeans = communcationMeans;
            }
            public void Communicate(string destination)
            {
                var communicate = communcationMeans.Communicate(destination);
                Console.WriteLine(communicate);
            }
        }

        static void Main(string[] args)
        {
            CommunicateViaPhone communicateViaPhone = new CommunicateViaPhone();
            CommunicateViaEmail communicateViaEmail = new CommunicateViaEmail();
            CommunicateViaVideo communicateViaVideo = new CommunicateViaVideo();

            CommunicationService communicationService = new CommunicationService();
            // via phone
            communicationService.SetCommuncationMeans(communicateViaPhone);
            communicationService.Communicate("1234567");
            // via email
            communicationService.SetCommuncationMeans(communicateViaEmail);
            communicationService.Communicate("hi@me.com");

            Console.ReadLine();

        }
    }
}
