using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSLADeliverables.Tests.Integration.Customer
{
    [TestClass]
    public class AppointmentTest
    {
        [TestMethod]
        public void PassesWhen_Customer_HasNoActiveAppointment_AndFetchesNoActiveAppointment()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void PassesWhen_Customer_HasOneActiveAppointment_AndFetchesOneActiveAppointment()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void PassesWhen_Customer_HasMoreThanOneActiveAppointments_AndFetchesMoreThanOneActiveAppointments()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void PassesWhen_Customer_CancelsAnActiveAppointmentBeforeCancellationWindow_AndNoFeeIsCharged()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void PassesWhen_Customer_CancelsAnActiveAppointmentWithinCancellationWindow_AndIsChargedWithPartialFee()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void PassesWhen_Customer_CancelsAnActiveAppointmentBeyondCancellationWindow_AndIsChargedWithFullFee()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void FailsWhen_Customer_CancelsCancelledAppointment()
        {
            Assert.Inconclusive();
        }  
    }
}
