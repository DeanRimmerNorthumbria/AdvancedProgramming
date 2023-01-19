using day_away_planner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_away_planner.Presenter
{
    interface IClient
    {
         int ClientID { get; set; }
         string ClientName { get; set; }
         string ClientCompany { get; set; }
         string ClientDepartment { get; set; }
         double ClientDebt { get; set; }
         bool ClientArrears { get; set; }

        List<Models.Client> ClientList(MyDBEntities DbEntities);
        List<Models.Client> FindClients(MyDBEntities DbEntities, string searchString);
    }
}

