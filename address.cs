using System;
using System.Collections.Generic;
using System.Linq;

  class Address
  {
      //Autoimplemented properties
      public string AddressLine1 { get; set; }
      public string AddressLine2 { get; set; }
      public string City { get; set; }
      public string State { get; set; }
      public string Zip { get; set; }

      public Address()
      {
          State = "NA";
          Zip = "00000";
      }
      public Address(string addr1, string addr2, string cityname, string statename, string zipname)
      {
          AddressLine1 = addr1;
          AddressLine2 = addr2;
          City = cityname;
          State = statename;
          Zip = zipname;
      }
      
  }
