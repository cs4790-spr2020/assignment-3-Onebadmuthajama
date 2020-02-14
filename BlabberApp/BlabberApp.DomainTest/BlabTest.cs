using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlabberApp.Domain.Models;
using System;

namespace BlabberApp.DomainTest {
    [TestClass]
    public class BlabTest {
        // getset tests should never fail.  period.
        [TestMethod]
        public void TestGetSetMessage() {
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
        public void TestGetSetUserID() {
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
        public void TestGetSetDateTime() {
            // Arrange
            var harness = new Blab();
            var expected = DateTime.UtcNow;
            harness.DateTime = expected;
            // Act
            var actual = harness.DateTime;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetSetID() {
            // Arrange
            var harness = new Blab();
            var expected = 1;
            harness.Id = expected;
            // Act
            var actual = harness.Id;
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
