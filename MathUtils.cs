using System;
namespace QuickTestApp
{
    public class MathUtils
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine(Average(10, 20));
            Console.ReadLine();
        }
         
        public static double Average(int a, int b)
        {
            //either is fine

            return (double)(a + b) / 2;            
            //return (a + b) / 2;
        }
    }
}
