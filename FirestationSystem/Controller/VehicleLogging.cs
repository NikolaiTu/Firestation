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
    public class VehicleLogging
    {
        private IFirebaseClient client;

        public VehicleLogging(IFirebaseClient firebaseClient)
        {
            client = firebaseClient;
        }

        public void AddVehicle(string name, string status, string shiftStartTime, string shiftEndTime)
        {
            try
            {
                var newVehicle = new
                {
                    Name = name,
                    Status = status,
                    ShiftStartTime = shiftStartTime, 
                    ShiftEndTime = shiftEndTime
                };

                PushResponse response = client.Push("Vehicles/", newVehicle);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Vehicle added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add Vehicle.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding vehicle: " + ex.Message);
            }
        }

        public async void RemoveVehicle(string VehicleName)
        {
            //FirebaseResponse response = await client.DeleteAsync($"Disasters1/{IncidentName}");
            //Console.WriteLine(response.StatusCode);

            FirebaseResponse response = client.Get("Vehicles/");
            Dictionary<string, Incidents> vehicleDict = response.ResultAs<Dictionary<string, Incidents>>();

            if (vehicleDict.Count > 1)
            {
                foreach (var entry in vehicleDict)
                {
                    if (entry.Value.Name == VehicleName)
                    {
                        FirebaseResponse deleteResponse = await client.DeleteAsync($"Vehicles/{entry.Key}");
                        MessageBox.Show(deleteResponse.StatusCode.ToString());
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("there must be one or more vehicles in order to remove one");
            }
        }
    }
}
