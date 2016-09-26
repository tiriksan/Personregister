using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Personregister.Controllers;

namespace Personregister.Tests
{
    [TestClass]
    public class PersonregisterControllerTests
    {
        [TestMethod]
        public void GetPersonByNIN_NIN01090097365_ReturnsJson()
        {
            PersonregisterController controller = new PersonregisterController();

            var json = controller.GetPersonByNIN("01090097365");

            Assert.IsTrue(json.Length > 0);
            Assert.IsTrue(json.Contains("\"NIN\":\"01090097365\""));
            Assert.IsTrue(json.Contains("\"GivenName\":\"MOHAMMED HATEM\""));
        }
    }
}
