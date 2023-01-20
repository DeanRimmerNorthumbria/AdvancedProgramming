//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using day_away_planner.Models;
using day_away_planner.Views;

namespace day_away_planner
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string parentStep1 = System.IO.Directory.GetParent(path).FullName;
            string parentStep2 = System.IO.Directory.GetParent(parentStep1).FullName;
            string parentStep3 = System.IO.Directory.GetParent(parentStep2).FullName;
            AppDomain.CurrentDomain.SetData("DataDirectory", parentStep3);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}