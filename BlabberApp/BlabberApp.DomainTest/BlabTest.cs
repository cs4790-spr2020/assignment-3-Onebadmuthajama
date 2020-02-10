using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain;
using System;

namespace BlabberApp.DomainTest
{
    [TestClass]
    public class BlabTest
    {
        [TestMethod]
        public void TestGetSetMessage()
        {
            // Arrange
            var harness = new Blab();       
            var expected = "Hello!";
            harness.Message = expected;
            // Act
            var actual = harness.Message;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSetUserID()
        {
            // Arrange
            var harness = new Blab();       
            var expected = "UserID!";
            harness.UserID = expected;
            // Act
            var actual = harness.UserID;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSetDateTime()
        {
            // Arrange
            var harness = new Blab();       
            var expected = DateTime.UtcNow;
            harness.DateTime = expected;
            // Act
            var actual = harness.DateTime;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
