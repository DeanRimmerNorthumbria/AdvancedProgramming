using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    internal class Client : IClient
    {
        public Client()
        {

        }

        public int VenueID { get; set; }
        public string VenueName { get; set; }
        public double VenueCost { get; set; }
        public string VenueExtras { get; set; }
        public string VenueLocation { get; set; }
        public int VenueCapacity { get; set; }

        public List<Models.Client> ClientList()
        {
            using (var context = new MyDBEntities())
            {
                var clientList = context.Clients.ToList<Models.Client>();
                return clientList;
            }
        }

        public List<Models.Client> FindClients(string searchString)
        {
            using (var context = new MyDBEntities())
            {
                var clientList = context.Clients.ToList<Models.Client>();
                var foundClients = new List<Models.Client>();
                
                foreach(var client in clientList)
                {
                    if (client.ClientCompany.Contains(searchString)){
                        foundClients.Add(client);
                    }
                }
                return foundClients;
            }
        }
    }


}
