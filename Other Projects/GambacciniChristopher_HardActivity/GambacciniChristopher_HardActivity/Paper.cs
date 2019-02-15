using System;
namespace GambacciniChristopher_HardActivity
{
    public class Paper
    {
       


            //create mvariables
            double monePaper;

            float mtwoPaper;

            int mthreePaper;

            //create 2 additional mvariables one with same datatype from each class
            string mrockPaper;

            double mscissorsPaper;

        //create default constructor
        public Paper()
        {

            //output to console
            Console.WriteLine("Paper defalult constructor");
        }

        //create constructor function 
        //add parameters
        public Paper(double _onepaper, float _twopaper, int _threepaper)
        {

            //set mvariables with parameter
            monePaper = _onepaper;

            mtwoPaper = _twopaper;

            mthreePaper = _threepaper;

            //output data to console
            Console.WriteLine("Paper 3 parameter constructor");


        }

        //create additional constructor function
        public Paper(string _paperrock)
        {

            //set mvariables with parameter
            mrockPaper= _paperrock;

            //output to console
            Console.WriteLine("Paper parameter: Rock");


        }

        //create additional constructor function
        public Paper(double _scissorspaper)
        {

            //set mvariables with parameter
            mscissorsPaper = _scissorspaper;


            Console.WriteLine("Paper parameter: Scissors");


        }
        public static void RockMethod()
        {

            Console.WriteLine("Paper method with parameter Rock");

        }

        //create additional method for papper 
        public static void RockMethod(string rock)
        {

            //create new object with Scissor Class
            Scissors scissorClass = new Scissors(rock);

            //output to console
            Console.WriteLine("Paper method with parameter Rock");


        }
        //create additional method for papper 
        public static void ScissorsMethod(double scissor)
        {


            //create new object with Paper Class
            Rock rockClass = new Rock(scissor);

            //output to console
            Console.WriteLine("Paper method with parameter Scissors");




        }
        public static void CombineMethod(string rock, double scissor)
        {

            Paper.RockMethod(rock);

            Paper.ScissorsMethod(scissor);

            Console.WriteLine("Paper calling both methods");


        }



    }


}
