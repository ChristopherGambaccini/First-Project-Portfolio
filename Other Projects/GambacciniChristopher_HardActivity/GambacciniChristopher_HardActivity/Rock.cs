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

            decimal mscissorsRock;


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
            public Rock(decimal _scissors)
            {

                //set mvariables with parameter
                mscissorsRock = _scissors;


                Console.WriteLine("Rock parameter: Scissors");


            }





    }
}
