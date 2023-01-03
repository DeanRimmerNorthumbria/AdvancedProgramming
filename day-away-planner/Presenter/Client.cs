using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    internal class Client
    {
        public Client()
        {

        }
        public List<Models.Client> getClientList()
        {
            using (var context = new MyDBEntities())
            {
                var clientList = context.Clients.ToList<Models.Client>();
                return clientList;
            }
        }
    }


}
