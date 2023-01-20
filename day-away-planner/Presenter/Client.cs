//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    public class Client : IClient
    {
        public Client()
        {

        }

        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientCompany { get; set; }
        public string ClientDepartment { get; set; }
        public double ClientDebt { get; set; }
        public bool ClientArrears { get; set; }

        public List<Models.Client> ClientList(MyDBEntities DbEntities)
        {
            using (var context = DbEntities)
            {
                var clientList = context.Clients.ToList<Models.Client>();
                return clientList;
            }
        }

        public List<Models.Client> FindClients(MyDBEntities DbEntities, string searchString)
        {
            using (var context = DbEntities)
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
