using FireSharp.Config;
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
    public class TruckLoader
    {
        private readonly IFirebaseClient client;

        public TruckLoader(IFirebaseClient firebaseClient)
        {
            client = firebaseClient;
        }

        public void LoadTrucks(Control.ControlCollection container, List<string> dispatchedTruckNames)
        {
            try
            {
                FirebaseResponse response = client.Get("Trucks/");
                Dictionary<string, Truck> trucksResult = response.ResultAs<Dictionary<string, Truck>>();

                foreach (var truck in trucksResult.Values)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Text = truck.Name;
                    checkBox.AutoSize = true;

                    // Check the checkbox if the truck is dispatched
                    if (dispatchedTruckNames != null && dispatchedTruckNames.Contains(truck.Name))
                    {
                        checkBox.Checked = true;
                    }

                    container.Add(checkBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trucks: {ex.Message}");
            }
        }

    }
}
