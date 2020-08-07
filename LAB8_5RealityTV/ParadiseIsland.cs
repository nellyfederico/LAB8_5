using System;
using System.Collections.Generic;
using System.Text;

namespace LAB8_5RealityTV
{
    class ParadiseIsland : Applications
    {
        public string Gender;
        public string NameOfBoyOrGirlfriend;
        public int YearsDating;

        public ParadiseIsland(string gender, string nameOfBoyOrGirlfriend, int yearsDating,
           string firstName, string lastName, string birthdate, string address, string city, string state, int zip,
           string phoneNumber, string email) : base(firstName, lastName, birthdate, address, city, state, zip, phoneNumber, email)
        {

            this.Gender = gender;
            this.NameOfBoyOrGirlfriend = nameOfBoyOrGirlfriend;
            this.YearsDating = yearsDating;
        }
        
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island");
        }
    }
}
