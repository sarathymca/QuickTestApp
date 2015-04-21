using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuickTestApp
{
    public class Run
    {
        public static int IndexOfLongestRun(string str)
        {
            Regex reg = new Regex(@"(\w)\1+");
            MatchCollection matches = reg.Matches(str);

            int longest = 0;
            int index = 0;
            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                if (longest < match.Length)
                {

                    index = match.Index; // Iniatialize the Index
                    longest = match.Length; // Stored the a consecutive sequence of the same character
                }
            }

            return index;
        }
        
        
        public static void Main(string[] args)
        {
            string InputValue = "";
            Console.WriteLine("Enter the input: ");
            InputValue = Console.ReadLine();
            Console.WriteLine(IndexOfLongestRun(InputValue));
            Console.ReadLine();
        }
         
    }

}
