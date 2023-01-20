//Ryan Chandler	w18009424@northumbria.ac.uk 
//Dean Rimmer	w18029848@northumbria.ac.uk
//Bhanu Prakash	w18029848@northumbria.ac.uk
//Precious Chidiadi Nwachukwu	22007369@northumbria.ac.uk
using day_away_planner.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace day_away_planner_UnitTesting
{
    [TestClass]
    public class ModelClientTesting
    {
        [TestMethod]
        public void TestClientID_IsKey()
        {
            // Arrange
            var prop = typeof(Client).GetProperty("ClientID");

            // Act
            var keyAttr = prop.GetCustomAttribute<KeyAttribute>();

            // Assert
            Assert.IsNotNull(keyAttr);
        }

        [TestMethod]
        public void TestClientName_IsRequired()
        {
            var prop = typeof(Client).GetProperty("ClientName");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestClientCompany_IsRequired()
        {
            var prop = typeof(Client).GetProperty("ClientCompany");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestClientDepartment_IsRequired()
        {
            var prop = typeof(Client).GetProperty("ClientDepartment");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestClientDebt_IsRequired()
        {
            var prop = typeof(Client).GetProperty("ClientDebt");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

        [TestMethod]
        public void TestClientArrears_IsRequired()
        {
            var prop = typeof(Client).GetProperty("ClientArrears");
            var requiredAttr = prop.GetCustomAttribute<RequiredAttribute>();
            Assert.IsNotNull(requiredAttr);
        }

    }
}

