using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class FunctionService
    {
        public bool IsValidGrade(int grade)
        {
            return grade >= 1 && grade <= 5;
        }
        public string GetLongerWorld(string word1, string word2)
        {
            if (word1.Length > word2.Length)
            {
                return word1;
            }
            if (word2.Length > word1.Length)
            {
                return word2;
            }
            return "Egyformák";        
        }
        public bool IsOpen(int hour)
        {
            return hour >= 8 && hour <16;
        }

        public bool InNegative(int negative)
        {

        }
    }
}