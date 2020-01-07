using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            //Here we want to create an instance of the reservation class.
            var reservation = new Reservation();
            //Act
            // Act on this object. Call on the method we are going to be testing. 
            //reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //I want to get the result and verify that the result is correct so I am going to store the result in a variable...
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            //Here you verify the result (variable you created to hold the results of the method you tested depending on which user it was) is true
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            //Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //Act
            // Act on this object. Call on the method we are going to be testing. 
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingRegistration_ReturnsFalse()
        {
            //Arrange

            var reservation = new Reservation { MadeBy = new User() };
            //    //Act
            var result = reservation.CanBeCancelledBy(new User());

            //    //Assert
            Assert.IsFalse(result);
        }
    }
}

//On tomorrow's studying: figure out why you pass in the {MadeBy = new User()}; to the new Reservation class and new user or user in the reservation.canbecancelledbymethod. Basically- idk how tests two and three got set up how they did.