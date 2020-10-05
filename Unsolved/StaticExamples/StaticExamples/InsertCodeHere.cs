using System;
using System.Collections.Generic;

namespace StaticExamples
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            #region ListMethods test
            List<int> aList = new List<int> { 23, 86, 51, 11, 39 };
          //  ListMethods listMethodsObject = new ListMethods();
            
            int smallest = ListMethods.FindSmallestNumber(aList);
            Console.WriteLine($"The smallest number in the list is : {smallest}");

            int average = ListMethods.FindAverage(aList);
            Console.WriteLine($"The average of the list is : {average}\n\n"); 
            #endregion


            Car c1 = new Car("233-2323",1000);

            c1.Price = 23;
            c1.Price = 23;
            c1.Price = 23;
            c1.Price = 23;
            Console.WriteLine(c1.Price);

            Car.PrintUsageStatistics();

            // The LAST line of code should be ABOVE this line
        }
    }
}