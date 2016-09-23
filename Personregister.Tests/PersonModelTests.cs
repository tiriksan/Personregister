using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Personregister.Models;
using Personregister.PersonServiceReference;

namespace Personregister.Tests
{
    [TestClass]
    public class PersonModelTests
    {
        [TestMethod]
        public void GetPerson_NIN01090097365_ReturnsPerson()
        {
            PersonModel model = new PersonModel();
            var testPerson = SetupPerson01090097365();
            

            var person = model.GetPerson(testPerson.NIN);

            Assert.AreEqual(testPerson.NIN, "01090097365");
            Assert.AreEqual(person.NIN, testPerson.NIN);
            Assert.AreEqual(person.GivenName, testPerson.GivenName);
        }


        private Person SetupPerson01090097365()
        {
            var testPerson = new Person();
            testPerson.NIN = "01090097365";
            testPerson.GivenName = "MOHAMMED HATEM";

            return testPerson;
        }
    }
}
