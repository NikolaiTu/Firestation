using FireSharp.Interfaces;
using FireSharp.Response;
using FirestationSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirestationSystem.Controller
{
    public class IncidentReport
    {
        private IFirebaseClient client;

        public IncidentReport(IFirebaseClient firebaseClient)
        {
            client = firebaseClient;
        }

        public void AddIncident(string name, string gps, string type, string description, string status, string responders)
        {
            try
            {
                var newIncident = new
                {
                    Name = name,
                    Gps = gps,
                    Type = type,
                    Description = description,
                    Status = status,
                    Responders = responders
                };

                PushResponse response = client.Push("Disasters/", newIncident);

                Console.WriteLine("Incident added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding incident: " + ex.Message);
            }
        }


    }
}
