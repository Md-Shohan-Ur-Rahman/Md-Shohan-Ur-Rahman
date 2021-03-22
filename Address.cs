using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcc
{
    public class Address
    {
        private string roadNo, houseNo, city, country;

        public Address(string roadNo, string houseNo, string city, string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }

        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }
        public string HouseNo
        {
            set { this.HouseNo = value; }
            get { return this.HouseNo; }
        }
        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }
        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }

       //This class has all the prperties for address and returns the address through GetAddress() method.
        public string Getaddress()
        {
            return this.roadNo + "," + this.houseNo + "," + this.city + "," + this.country;
        }
    }
}
