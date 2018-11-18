using ACM.BL;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ACM.BL.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValid()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;


            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidAndSame()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;


            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatePercentOfGoalStepsTestValidActualIsZero()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;


            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);


            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNull()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = null;
            string actualSteps = "0";

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert
 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestActualIsNull()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = null;

            // Act
            var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);

            // Assert

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestGoalIsNotNumeric()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "one";
            string actualSteps = "0";

            // Act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Goal must be numeric", ex.Message);
                throw;
            }

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentOfGoalStepsTestActualIsNotNumeric()
        {
            // Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "one";

            // Act
            try
            {
                var actual = customer.CalculatePercentOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Steps must be numeric", ex.Message);
                throw;
            }

            // Assert
        }


    }
}
