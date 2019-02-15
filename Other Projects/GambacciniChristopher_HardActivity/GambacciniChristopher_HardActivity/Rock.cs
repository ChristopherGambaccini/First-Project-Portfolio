using System;
namespace GambacciniChristopher_HardActivity
{
    public class Rock
    {


            //create 3 mvariables

            string moneRock;

            int mtwoRock;

            double mthreeRock;

            //create 2 additional mvariables one with same datatype from each class
            float mpaperRock;

            double mscissorsRock;

        //create default constructor
        public Rock()
        {

            //output to console
            Console.WriteLine("Rock defalult constructor");
        }


        //create constructor function
        //add parameters 
        public Rock(string _onerock, int _tworock, double _threerock)
            {

                //set mvariables with parameters

                moneRock = _onerock;

                mtwoRock = _tworock;

                mthreeRock = _threerock;

                //output data to console
                Console.WriteLine("Rock 3 parameter constructor");


            }
            //create additional constructor function
            public Rock(float _paper)
            {

                //set mvariables with parameter
                mpaperRock = _paper;


                Console.WriteLine("Rock parameter: Paper");




            }
            //create additional constructor function
            public Rock(double _scissors)
            {

                //set mvariables with parameter
                mscissorsRock = _scissors;


                Console.WriteLine("Rock parameter: Scissors");




            }


        //create additional method for papper 
        public static void PaperMethod(float paper)
        {
           
            //create new object with Scissor Class
            Scissors scissorClass = new Scissors(paper);

            //output to console
            Console.WriteLine("Rock method with parameter Paper");


        }
        //create additional method for papper 
        public static void ScissorsMethod(double scissor)
        {


            //create new object with Paper Class
            Paper paperClass = new Paper(scissor);

            //output to console
            Console.WriteLine("Rock method with parameter Scissors");




        }
        public static void CombineMethod(float paper, double scissor)
        {

            Rock.PaperMethod(paper);

            Rock.ScissorsMethod(scissor);

            Console.WriteLine("Rock calling both methods");


        }



    }
}
