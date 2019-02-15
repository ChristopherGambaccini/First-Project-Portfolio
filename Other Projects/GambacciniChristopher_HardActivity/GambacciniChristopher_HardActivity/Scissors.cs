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


        //create default constructor
        public Scissors(string rock)
        {

            //output to console
            Console.WriteLine("Scissors defalult constructor");
        }

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
 
       
        public static void RockMethod()
        {

            Console.WriteLine("Scissors method with parameter Rock");

        }

       
         //create additional method for papper 
        public static void RockMethod(int rock)
        {

            //create new object with Scissor Class
            Paper scissorClass = new Paper(rock);

            //output to console
            Console.WriteLine("Scissors method with parameter Rock");


        }
        //create additional method for papper 
        public static void PaperMethod(float paper)
        {


            //create new object with Paper Class
            Rock paperClass = new Rock(paper);

            //output to console
            Console.WriteLine("Scissors method with parameter Paper");




        }
        public static void CombineMethod(int rock, float paper)
        {

            Scissors.RockMethod(rock);

            Scissors.PaperMethod(paper);

            Console.WriteLine("Scissors calling both methods");


        }



    }
}
