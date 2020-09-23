using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TersString
{
   public class Program
    {
        public string KelimeTers(string kelime)
        {
            string reverseString = ReverseString(kelime);
            return reverseString;
        }
        public string ReverseString(string inputString)
        {
            string reverString = "";
            for(int i = inputString.Length - 1;i >= 0; i--)
            {
                reverString += inputString[i];
            }
            return reverString;
        }
        static void Main(string[] args)
        {
        }
    }
}
