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

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Incident added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add Incident.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding incident: " + ex.Message);
            }
        }

        public async void RemoveIncident(string IncidentName)
        {
            //FirebaseResponse response = await client.DeleteAsync($"Disasters1/{IncidentName}");
            //Console.WriteLine(response.StatusCode);

            FirebaseResponse response = client.Get("Disasters/");
            Dictionary<string, Incidents> incidentDict = response.ResultAs<Dictionary<string, Incidents>>();

            if (incidentDict.Count > 1)
            {
                foreach (var entry in incidentDict)
                {
                    if (entry.Value.Name == IncidentName)
                    {
                        FirebaseResponse deleteResponse = await client.DeleteAsync($"Disasters/{entry.Key}");
                        MessageBox.Show(deleteResponse.StatusCode.ToString());
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("there must be one or more disasters in order to delete something");
            }
        }
    }
}
