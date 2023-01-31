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
            AbstractLineCompare compare= new LineCompare();
            compare.Compare();
            Console.ReadLine();
        }
        
    }
}
