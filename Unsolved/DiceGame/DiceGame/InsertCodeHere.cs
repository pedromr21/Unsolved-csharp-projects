using System;

namespace DiceGame
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            DiceCup cup = new DiceCup();

            Console.WriteLine($"The sum of the dice is {cup.TotalValue}");

            cup.Shake();

            Console.WriteLine($"The sum of the dice is {cup.TotalValue}");


            // The LAST line of code should be ABOVE this line
        }
    }
}