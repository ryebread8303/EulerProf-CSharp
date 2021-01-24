using System;
using System.Collections.Generic;

namespace library
{
    public class Multiples
    {
        public static List<int> of (int of,int under)
        {
            // initialize variables
            int current = 0;
            List<int> result = new List<int>();
            // loop through all the multiples
            do 
            {
                current += of;
                if(current < under)
                {
                    result.Add(current);
                } else
                {
                    break;
                }
            } while (current < under);
            return result;
        }
    }
}
