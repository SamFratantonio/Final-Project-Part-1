using System;
using System.Collections.Generic;
using System.Linq;

class Person
    {
        //Auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SocialSecurity { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //private
        Address PermanentAddress;//Composition

        //Constructors
        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            SocialSecurity = "Unknown";
            PermanentAddress = new Address();
        }

        //Constructor with 3 arguments
        public Person(string fname, string lname, string ssn)
        {
            FirstName = fname;
            LastName = lname;
            SocialSecurity = ssn;
            PermanentAddress = new Address();//call this when there is no data available to set address
        }

        //Constructor with 3 arguments
        public Person(string fname, string lname, string ssn, string addr1, string addr2, string cityname, string statename, string zipcode)
        {
            FirstName = fname;
            LastName = lname;
            SocialSecurity = ssn;
            PermanentAddress = new Address(addr1,addr2,cityname,statename,zipcode);//call this when you have address info
        }

        public virtual void Intro()
        {
            Console.WriteLine("Hello my name is {0} {1}", FirstName, LastName);
        }

        public void SetAddress(string addr1, string addr2, string cityname, string statename, string zipname)
        {
            PermanentAddress.AddressLine1 = addr1;
            PermanentAddress.AddressLine2 = addr2;
            PermanentAddress.City = cityname;
            PermanentAddress.State = statename;
            PermanentAddress.Zip = zipname;
        }

        public bool IsBirthday()
        {
            //compare the month and day of today with date of birth
            if (DateOfBirth.Day == DateTime.Today.Day && DateOfBirth.Month == DateTime.Today.Month)
                return true;

            return false;
        }
    }
        
