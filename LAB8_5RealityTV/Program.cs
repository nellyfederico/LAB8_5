using System;

namespace LAB8_5RealityTV
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseHunter Contestant2 = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975",
                  "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");

            ParadiseIsland Contestant3 = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angeles",
                "California", 90001, "988-444-1234", "patti.johnson@gmail.com");

            AboveDeck Contestant1 = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angeles",
            "California", 90001, "711-333-1234", "captian@gmail.com");
            
            Contestant1.Submit();
            Contestant1.Accept();
            Contestant2.Submit();
            Contestant2.Accept();
            Contestant3.Submit();
            Contestant3.Accept();
            


        }
    }
}
