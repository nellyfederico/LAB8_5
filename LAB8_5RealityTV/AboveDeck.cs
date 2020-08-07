using System;
using System.Collections.Generic;
using System.Text;

namespace LAB8_5RealityTV
{
    class AboveDeck : Applications
    {
        public int YearsOfExperience;
        public string Nationality;

        public AboveDeck(int yearsExperience, string nationality,
            string firstName, string lastName, string birthdate, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, birthdate, address, city, state, zip, phoneNumber, email)
        {

            this.YearsOfExperience = yearsExperience;
            this.Nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck");
        }
    }
}
