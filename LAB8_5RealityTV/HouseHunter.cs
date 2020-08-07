using System;
using System.Collections.Generic;
using System.Text;

namespace LAB8_5RealityTV
{
    class HouseHunter : Applications
    {
        public string jobTitle;
        public int annualIncome;
        public int dateOfNewHouse;
        public int numOfBedrooms;
        public int numOfBathrooms;

        public HouseHunter(string jobTitle, int currentIncome, int dateBuyingHouse, int bedrooms, int bathrooms,
           string firstName, string lastName, string birthdate, string address, string city, string state, int zip,
           string phoneNumber, string email) : base(firstName, lastName, birthdate, address, city, state, zip, phoneNumber, email)
        {

            this.jobTitle = jobTitle;
            this.annualIncome = currentIncome;
            this.dateOfNewHouse = dateBuyingHouse;
            this.numOfBedrooms = bedrooms;
            this.numOfBathrooms = bathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters");
        }
    }
}
