using System;

namespace OpenHouseProject.AMJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Home homeOne = new Home();
            homeOne.HomeName = "Traditional Split Level";
            homeOne.HouseDescription = "This house features a big yard, gas stove but lacks charm. It is move in ready granite counter tops, has room for a mancave.";
            homeOne.BestHouseFeature = "This traditional split level has drawn on windows. It is super energy efficient and great for people who like the dark.";
            homeOne.BuyThisHomeResponse = "Too bad it is 5 cents over your budget and the homeowners are NON-NEGOTIABLE! They really feel the market will bring them that extra 5 cents!";
            Home.HomeList.Add(homeOne);

            Home homeTwo = new Home();
            homeTwo.HomeName = "ManCave Home";
            homeTwo.HouseDescription = "The mancave house has a big yard, plenty of closet space and a large 1/2 car garage! Believe it or not the floor is vertical.";
            homeTwo.BestHouseFeature = "The best feature is that the tub is filled with magicians! It's really a magical experience!";
            homeTwo.BuyThisHomeResponse = "Sorry this house has already sold. I told you those magicians were a hot feature!";
            Home.HomeList.Add(homeTwo);

            Home homeThree = new Home();
            homeThree.HomeName = "Split Level Ranch";
            homeThree.HouseDescription = "This house features a great yard, the foyer of your dreams and room for a mancave. However, it is 1000 miles from civilization. ";
            homeThree.BestHouseFeature = " You will never run out of towel racks as this house has 100 towel racks for all your racking needs.";
            homeThree.BuyThisHomeResponse = "Unfortunately there were 3 bids on this house and it sold for 225% over asking price! You snooze you lose! ";
            Home.HomeList.Add(homeThree);

            Home homeFour = new Home();
            homeFour.HomeName = "Hidden Valley Ranch";
            homeFour.HouseDescription = "Well this house is the most economical choice. It is definitely in your budget but it is the size of a Hidden Valley Ranch packet. The tiny house features no yard, no storage. ";
            homeFour.BestHouseFeature = "The best feature of this house is it is offered at ONLY $425 per square foot.";
            homeFour.BuyThisHomeResponse = "Well this one sold before it came on the market. It was a pocket listing.";
            Home.HomeList.Add(homeFour);

            Home homeFive = new Home();
            homeFive.HomeName = "The houses you really don't want to see!";
            homeFive.HouseDescription = "This is the coolest house as it is invisible! A very modern minimalist approach to architecture.";
            homeFive.BestHouseFeature = "It allows you to really get to know your neighbors as they can watch you shower! ";
            homeFive.BuyThisHomeResponse = "Unfortuantely, this one has major structural issues! Keep looking!";
            Home.HomeList.Add(homeFive);

            //Home homeTheONE = new Home();
            //homeTheONE.HomeName = "The Abandoned Split Level Filled with Australian Vampires";
            //homeTheONE.HouseDescription = "This House has a beautiful fence to contain all of your CRAZY relatives. It doesn't come with a mancave but it does have a man in the basement. The previous owners were Do It Yourselfers! The highend gas stove is already installed and conveniently located on the master bed.";
            //homeTheONE.BestHouseFeature = "The master toilet is located on the ceiling. It is an very popular trend in new construction!";
            //homeTheONE.BuyThisHomeResponse = "The asking price is $390,000.";
            //Home.HomeList.Add(homeTheONE);

            Realtor realtor = new Realtor();
            realtor.Name = "David";

            realtor.Speak("Hello, you want to buy a house? Let's start looking.");

            //Show list of homes to see
            realtor.ShowHomes();
            Console.WriteLine("I really think this is the house that you have been looking for after 399 months of house hunting. Do you want to see it?");
            Console.ReadLine();

            
            
        }
    }
}
