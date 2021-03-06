﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KantoorApplicatie.Models.Invoice 
{
    public class Representative 
    {
        public int RepresentativeId { get; set; }
        public string companyName { get; set; }
        public string postalCode { get; set; }
        public string location { get; set; }
        public string phonenumber { get; set; }
        public string emailadres { get; set; }
        public string kvkNumber { get; set; }
        public string iban { get; set; }

        public Representative(string companyName, string postalCode, string location, string phonenumber, string emailadres, string kvkNumber, string iban) 
        {
            this.companyName = companyName;
            this.postalCode = postalCode;
            this.location = location;
            this.phonenumber = phonenumber;
            this.emailadres = emailadres;
            this.kvkNumber = kvkNumber;
            this.iban = iban;
        }

        public Representative() 
        {
        }

        public override string ToString() 
        {
            return "Representative:" +
                "\ncompanyName: " + companyName +
                "\npostalcode: " + postalCode;
        }
    }
}
