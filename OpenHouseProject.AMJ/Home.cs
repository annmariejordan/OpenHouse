using System;
using System.Collections.Generic;

namespace OpenHouseProject.AMJ
{
    class Home
    {
        public static List<Home> HomeList = new List<Home>();

        public string HomeName { get; set; }
        public string HouseDescription { get; set; }
        public string BestHouseFeature { get; set; }
        public string BuyThisHomeResponse { get; set; }



        public void ShowHouse(Realtor realtor1)
        {
            
            Console.WriteLine("Great let's learn about " + HomeName + ".");

            //show house description that was selected

            realtor1.Speak(HouseDescription);
            
            ////Ask Do you want to see the best feature with CWL Y/N
            realtor1.Speak("But that is not all. Do you want to see the best feature? Answer Y or N:");

           
            string bestFeatureResponse = Console.ReadLine();
            string choice = bestFeatureResponse.ToUpper();
            if (choice == "Y") 
            {
                realtor1.Speak(BestHouseFeature);
            }
            else
            {
                realtor1.Speak("Too bad, you need to know this! The best feature is " + BestHouseFeature + ".");
            }

            //Speak("Do you want to buy this house?")
            realtor1.Speak("Do you want to buy this house?");
            string buyerPurchaseResponse = Console.ReadLine();
            string choice2 = buyerPurchaseResponse.ToUpper();
            if (choice2 == "Y")
            {
                realtor1.Speak(BuyThisHomeResponse);
            }
     

        }

    }
}