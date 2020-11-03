using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace FilteringV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            
            List<int> values = new List<int>() {12, 24, 9, 10, 6, 3, 45};
            Console.WriteLine("Full Number List");

                Console.WriteLine($"12, 24, 9, 10, 6, 3, 45");


            List<int> filteredValues1 = Filter.FilterValues(values, new FilterLessThan8()); // Initialize the filter

            Console.WriteLine($"Filter Less than 8");


            foreach (var value in filteredValues1)
            {
                Console.Write($" {value} ");
            }

            Console.WriteLine($"\nFilter More than 8");

            List<int> filteredValues2 = Filter.FilterValues(values, new FilterMoreThan8()); // Initialize the filter
            foreach (var value in filteredValues2)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}