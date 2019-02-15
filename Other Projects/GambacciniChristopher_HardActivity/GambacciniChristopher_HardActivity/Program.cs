using System;

namespace GambacciniChristopher_HardActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            //create first object by calling constructor
            Rock firstObject = new Rock(" " , 0 , 0);

            //create second object by calling constructor
            Paper secondObject = new Paper(0 , 0 , 0);

            //create thrid object by calling constructor
            Scissors thirdObject = new Scissors(" ", 0 , 0 );

            Rock.CombineMethod(0 , 0);

            Paper.CombineMethod("0" , 0);

            Scissors.CombineMethod(0, 0);
        }
    }
}
