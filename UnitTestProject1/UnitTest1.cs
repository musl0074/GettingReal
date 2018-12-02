using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GettingReal;
using CultureTravelLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {       
            Controller controller;
            TripRepo tripRepo;
             

        [TestInitialize]
        public void SetupForTest()
        {
            controller = new Controller();
            tripRepo = controller.GetTripRepo();
            controller.CreateTrip("Marokko", "01-06-2018");
            controller.CreateTrip("Barcelona", "01-10-2018");
        }

        [TestMethod]
        public void TestCreateTrip()
        {
            controller.CreateTrip("Holland", "05-02-2018");
            Assert.AreEqual(3, tripRepo.ShowTrips().Count);
        }
        
        [TestMethod]
        public void TestCreateTripCustomer ()
        {
            controller.CreateTrip("Denmark", "03-08-1943");
            controller.CreateTripCustomer("Hans", "", "", "", "", "", "", "", "", "Denmark");
            Trip t = tripRepo.GetTrip("Denmark");
            var tripCustomers = t.GetTripCustomers();

            Assert.AreEqual(1, tripCustomers.Count);
        }

        [TestMethod]
        public void TestTripCustomerName ()
        {
            controller.CreateTrip("Denmark", "03-08-1943");
            controller.CreateTripCustomer("Hans", "", "", "", "", "", "", "", "", "Denmark");
            Trip t = tripRepo.GetTrip("Denmark");
            var tripCustomers = t.GetTripCustomers();
            TripCustomer c = tripCustomers[0];

            Assert.AreEqual("Hans", c.Name);
        }


    }
   
}
