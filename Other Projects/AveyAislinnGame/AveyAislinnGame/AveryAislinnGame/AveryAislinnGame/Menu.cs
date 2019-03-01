using System;
namespace AveryAislinnGame
{
    class Menu
    {
        public static void MenuSelection()
        {
            //create loop to cycle through application until user selects exit

            bool menuChoice = true;
            while (menuChoice)
            {



                //Provide instructions to user
                Console.WriteLine("Below is a menu of 8 Fun Games, choose wisley!\r\n");

                //list menu of application
                Console.WriteLine("\r\n1. Horses\r\n2. Dinosaurs\r\n3. LOL Dols\r\n4. Peppa Pig\r\n5. Unicorns\r\n6. Zombiesr\r\n7. Dog ate my homework\r\n8. But dad\r\n9. Exit\r\n");

                //create variable to hold input
                string selectionString = Console.ReadLine();

                //derfine int variable
                int selection;

                //validate user input was correct data
                while (!int.TryParse(selectionString, out selection) || (selection < 1 || selection > 9))
                {

                    //remprompt user for correct input
                    Console.WriteLine("\r\nOops you entered the something other than 1 - 9.\r\nPlease reenter your selection below.");

                    //recapture user input
                    selectionString = Console.ReadLine();

                }

                //clear screen
                Console.Clear();


                //create switch statement to cycle through input
                switch (selection)
                {
                    case 1:

                        //return call from Horses Class Method
                        break;

                    case 2:

                        //return call from Dinsaurs Class Method
                        break;

                    case 3:

                        //return call from LOLDolls Class Method
                        break;

                    case 4:

                        //return call from PeppaPig Class Method
                        break;

                    case 5:

                        //return call from Unicorns Class Method
                        break;


                    case 6:

                        //return call from Zombies Class Method
                        break;

                    case 7:

                        //return call from DogAteMyHomework Class Method
                        break;

                    case 8:

                        //return call from ButDad Class Method
                        break;

                }

                //create user exit with conditional
                if (selection == 9)
                {

                    break;

                }





            }





        }
    }
}
