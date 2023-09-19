using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using School;

namespace School.Tests
{
    [TestFixture]
    public class ClassTests
    {
        [Test]
        public void TestClassName()
        {
            // Arrange
            Class myClass = new Class();
            myClass.Name = "Math";

            // Act
            string className = myClass.Name;

            // Assert
            Assert.AreEqual("Math", className);
        }

        [Test]
        public void TestClassId()
        {
            // Arrange
            Class myClass = new Class();
            myClass.Id = 1;

            // Act
            int classId = myClass.Id;

            // Assert
            Assert.AreEqual(1, classId);
        }
    }
}
