﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KantoorApplicatie.Models.Theme;

namespace KantoorApplicatie.Models.Invoice 
{
    public class Customer 
    {
        public int CustomerId { get; set; }
        public string companyName { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string postalCode { get; set; }
        public string location { get; set; }
        public string adres { get; set; }
        public string phonenumber { get; set; }
        public string email { get; set; }
        public string kvkNumber { get; set; }
        public string iban { get; set; }
        public int subThemeId { get; set; }

        public Customer(string companyName, string name, string department, string postalCode, string location, string adres, string phonenumber, string email, string kvkNumber, string iban) 
        {
            this.companyName = companyName;
            this.name = name;
            this.department = department;
            this.postalCode = postalCode;
            this.location = location;
            this.adres = adres;
            this.phonenumber = phonenumber;
            this.email = email;
            this.kvkNumber = kvkNumber;
            this.iban = iban;
        }

        public Customer(string companyName, string name, string department, string postalCode, string location, string adres, string phonenumber, string email, string kvkNumber, string iban, int SubthemeId) 
            :this(companyName, name, department, postalCode, location, adres, phonenumber, email, kvkNumber, iban)
        {
            this.subThemeId = SubthemeId;
        }

        public Customer() 
        {
        }
    }
}
