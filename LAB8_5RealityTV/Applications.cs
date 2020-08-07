using System;
using System.Collections.Generic;
using System.Text;

namespace LAB8_5RealityTV
{
    class Applications
    {
        public string firstName;
        public string lastName;
        public string birthdate;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public string Phone;
        public string Email;
        public bool Submitted;
        public bool Accepted;

        public Applications(string firstName, string lastName, string birthdate, string address, string city, string state, int zip,
            string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phoneNumber;
            this.Email = email;
            Submitted = false;
            Accepted = false;

        }
        public void Submit()
        {
            Submitted = true;
            Console.WriteLine("Application has been Submitted");
        }

        public virtual void Accept()
        {
            Accepted = true;
            Console.WriteLine("Application Accepted");
        }

    }
}
