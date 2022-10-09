using NUnit.Framework;
using System;
using System.Data;
using System.Linq;
using System.Text;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            
            return String.Concat(str.OrderBy(ch => ch));
            
        }
    }
}
