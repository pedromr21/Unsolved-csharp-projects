﻿using System.Collections.Generic;

namespace FilteringV10
{
    /// <summary>
    /// Class capable on filtering a List of integers.
    /// Current filtering condition:
    /// Include values larger than 10.
    /// </summary>
    public static class Filter
    {
        public static List<int> FilterValues(List<int> values, IFilterCondition filter)
        {
            List<int> filteredValues = new List<int>();
            
            
            foreach (var value in values)
            {
                if (filter.Condition(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }
    }
}