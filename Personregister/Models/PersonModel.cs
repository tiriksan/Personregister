﻿using Personregister.PersonServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personregister.Models
{
    public class PersonModel
    {
        public Person GetPerson(string NIN)
        {
            PersonServiceClient client = new PersonServiceClient();
            client.ClientCredentials.UserName.UserName = "test";
            client.ClientCredentials.UserName.Password = "BF32511";
            LookupParameters lookupParameter = new LookupParameters();
            lookupParameter.NIN = NIN;
            var person = client.GetPerson(lookupParameter);

            client.Close();

            return person;
        }
    }
}