//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w21052079@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using day_away_planner.Presenter;
using day_away_planner.Models;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using Moq;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class PresenterClientTesting
    {
        private day_away_planner.Presenter.Client client = new day_away_planner.Presenter.Client();
        [TestMethod]
        public void TestGetSetClientID()
        {
            client.ClientID = 1;
            Assert.AreEqual(1, client.ClientID);
        }
        [TestMethod]
        public void TestGetSetClientName()
        {
            Assert.IsNull(client.ClientName);
            client.ClientName = "bob";
            string clientName = client.ClientName;
            Assert.AreEqual(3, clientName.Length);
            Assert.AreEqual("bob", client.ClientName);
        }
        [TestMethod]
        public void TestGetSetClientComany()
        {
            Assert.IsNull(client.ClientCompany);
            client.ClientCompany = "company";
            Assert.AreEqual(7, client.ClientCompany.Length);
            Assert.AreEqual("company", client.ClientCompany);
        }
        [TestMethod]
        public void TestGetSetClientDebt()
        {
            Assert.AreEqual(0, client.ClientDebt);
            client.ClientDebt = 1.12;
            Assert.AreEqual(1.12, client.ClientDebt);
            client.ClientDebt += 1.12;
            Assert.AreEqual(2.24, client.ClientDebt);
        }
        [TestMethod]
        public void TestGetSetClientArrears()
        {
            Assert.AreEqual(client.ClientArrears, false);
            client.ClientArrears = true;
            Assert.AreEqual(client.ClientArrears, true);
        }
        [TestMethod]
        public void TestGetAllClients()
        {
            var context = new MyDBEntities();
            var clientList = client.ClientList(context);
            Assert.IsNotNull(clientList[0].ClientID);
            Assert.IsInstanceOfType(clientList[0], typeof(day_away_planner.Models.Client));
        }
        [TestMethod]
        public void TestGetFilterClients()
        {
            var context = new MyDBEntities();
            var clientList = client.FindClients(context, "not a company which will exist within the database");
            Assert.AreEqual(0, clientList.Count);
            var contextcall2 = new MyDBEntities();
            clientList = client.FindClients(contextcall2, "Bloom");
            Assert.IsTrue(clientList.Count > 0);
            Assert.IsInstanceOfType(clientList[0], typeof(day_away_planner.Models.Client));
        }
    }
}
