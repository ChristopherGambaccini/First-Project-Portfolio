using System;
namespace GambacciniChristopher_HardActivity
{
    public class Scissors
    {
       

            //create mvariables
            string moneeScissors;

            decimal mtwoScissors;

            double mthreeScissors;

            //create 2 additional mvariables one with same datatype from each class
            int mrockScissors;

            float mpaperScissors;


        //create constructor function 
        //add parameters
        public Scissors(string _onescissors, decimal _twoscissors, double _threescissors)
        {

            //set mvariables with parameter
            moneeScissors = _onescissors;

            mtwoScissors = _twoscissors;

            mthreeScissors = _threescissors;

            //output data to console
            Console.WriteLine("Scissors 3 parameter constructor");


        }
        //create additional constructor function
        public Scissors(int _rockscissors)
        {

            //set mvariables with parameter
            mrockScissors = _rockscissors;

            //output to console
            Console.WriteLine("Scissors parameter: Rock");


        }
        //create additional constructor function
        public Scissors(float _paperscissors)
        {

            //set mvariables with parameter
            mpaperScissors = _paperscissors;

            //output to console
            Console.WriteLine("Scissors parameter: Paper");


        }



    }
}
