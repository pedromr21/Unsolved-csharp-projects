using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringV10
{
    class FilterMoreThan8 : IFilterCondition
    {
        public bool Condition(int value)
        {
            return value > 8;
        }
    }
}
