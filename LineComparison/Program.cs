using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Console.WriteLine("Enter the Line Co-Ordinates");
            Console.WriteLine("Enter the Co-Ordinates of First Line");
            Console.WriteLine("Enter the X1 Value: ");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y1 Value: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the X2 Value: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y2 Value: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double lineLength1= Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of Line = " + lineLength1);
            Console.ReadLine();
        }
    }
}
