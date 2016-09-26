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

            Assert.AreEqual("01090097365", testPerson.NIN);
            Assert.AreEqual(testPerson.NIN, person.NIN);
            Assert.AreEqual(testPerson.GivenName, person.GivenName);
        }

        [TestMethod]
        public void GetPerson_NIN21058047691_ReturnsPerson()
        {
            PersonModel model = new PersonModel();

            var person = model.GetPerson("21058047691");

            Assert.AreEqual(person.NIN, "21058047691");
            Assert.AreEqual("ELLA CHRISTINE", person.GivenName);
        }

        [TestMethod]
        public void GetPerson_NIN13049544221_ReturnsPerson()
        {
            PersonModel model = new PersonModel();

            var person = model.GetPerson("13049544221");

            Assert.AreEqual("13049544221", person.NIN);
            Assert.AreEqual("ELIN MONICA", person.GivenName);
        }

        [TestMethod]
        public void GetPerson_NIN25065041963_ReturnsPerson()
        {
            PersonModel model = new PersonModel();

            var person = model.GetPerson("25065041963");

            Assert.AreEqual("25065041963", person.NIN);
            Assert.AreEqual("EIVIND OTTO", person.GivenName);
        }

        [TestMethod]
        public void ConvertPersonToJSON_SuccessfullyConvertTestPersonToJson()
        {
            PersonModel model = new PersonModel();
            Person testPerson = new Person() { NIN = "12345678", GivenName = "Test Tester" };

            var json = model.ConvertPersonToJSON(testPerson);

            Assert.IsNotNull(json);
            Assert.AreEqual("{\"Addresses\":null,\"Citizenship\":null,\"CitizenshipCode\":null,\"Custody\":null,\"DateCitizenship\":null,\"DateCustody\":null,\"DateMaritalStatus\":null,\"DateOfBirth\":null,\"DateParentalResponsibility\":null,\"DateStatus\":null,\"DateWithoutLegalCapacity\":null,\"DateWorkPermit\":null,\"DufNo\":null,\"FathersNIN\":null,\"GivenName\":\"Test Tester\",\"MaritalStatus\":null,\"MiddleName\":null,\"MothersNIN\":null,\"NIN\":\"12345678\",\"NewNIN\":null,\"OldNIN\":null,\"ParentalResponsibility\":null,\"RegStatus\":null,\"Sn\":null,\"SpouseNIN\":null,\"StatusCountryCode\":null,\"WithoutLegalCapacity\":null,\"WorkPermit\":null}", json);
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
