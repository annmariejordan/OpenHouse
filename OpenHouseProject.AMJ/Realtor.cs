using System;

namespace OpenHouseProject.AMJ
{
    class Realtor
    {
        //private object homeTheONE;

        public string Name { get; set; }


        public void Speak(string message)
        {
            Console.WriteLine(message);

        }
        public void ShowHomes()
        {
            Home homeToShow = GetNextHouse();
            while (homeToShow != null )
            {
                homeToShow.ShowHouse(this);
                homeToShow = GetNextHouse();
            }
            Speak("We do have one more...");

        }

        //public void showFinalHouse();
        //{
        //    Home 
        //}

        public Home GetNextHouse()
        {
            if (Home.HomeList.Count == 0)
            {
                return null;
            }
            
            //display list
            Speak("Choose a home from the list. ");


            for (int i = 0; i < Home.HomeList.Count; i++)
            {
                
                Speak(i+1 + ") " + Home.HomeList[i].HomeName);
               
            }

            //get user feedback 
            string buyerResponse = Console.ReadLine();
            int answerBuyerResponse = int.Parse(buyerResponse)-1;

            Home ChosenHome = Home.HomeList[answerBuyerResponse];
            //Remove selection from the list
            Home.HomeList.RemoveAt(answerBuyerResponse);

            
            return ChosenHome;
        }
        
    }
}
