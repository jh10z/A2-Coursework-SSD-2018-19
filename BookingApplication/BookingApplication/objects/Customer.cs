using System;
using BookingApplication.exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.objects
{
    public class Customer
    {
        int customerId;
        string forename;
        string surname;
        DateTime dob;
        string address;
        string town;
        string postcode;
        bool activeUser;
        string emailAddress;
        string telNo;

        public Customer()
        {
        }

        public Customer(int customerId, string forename, string surname, DateTime dob, string address, string town, string postcode, bool activeUser, string emailAddress, string telNo)
        {
            this.customerId = customerId;
            this.forename = forename;
            this.dob = dob; 
            this.surname = surname;
            this.address = address;
            this.town = town;
            this.postcode = postcode;
            this.activeUser = activeUser;
            this.emailAddress = emailAddress;
            this.telNo = telNo;
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string Forename
        {
            get { return forename; }
            set { forename = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Town
        {
            get { return town; }
            set { town = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public bool ActiveUser
        {
            get { return activeUser; }
            set { activeUser = value; }
        }

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        public string TelNo
        {
            get { return telNo; }
            set
            { 
                 telNo = value;
            }
        }

        public override string ToString()
        {
            if(customerId == -1)
            {               
                return "(Not Specified)";
            }
            else
            {
                return forename + " " + surname + " (ID: " + customerId + ")";
            }
        }
    }
}
