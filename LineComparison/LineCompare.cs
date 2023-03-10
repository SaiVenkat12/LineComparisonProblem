using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineCompare : AbstractLineCompare
    {
        public override void Compare()
        {
            Console.WriteLine("Enter the Line Co-Ordinates");

            Console.WriteLine("Enter the Co-Ordinates of First Line");
            Console.WriteLine("Enter the X1 Value: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y1 Value: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the X2 Value: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y2 Value: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Co-Ordinates of Second Line");
            Console.WriteLine("Enter the X3 Value: ");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y3 Value: ");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the X4 Value: ");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y4 Value: ");
            int y4 = Convert.ToInt32(Console.ReadLine());
            double lineLength1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            double lineLength2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            Console.WriteLine("Length of Line1 = " + lineLength1);
            Console.WriteLine("Length of Line2 = " + lineLength2);
            int lineComparsion = lineLength1.CompareTo(lineLength2);
            if (lineComparsion == 0)
            {
                Console.WriteLine("Both the Lines are Equal");
            }
            else if (lineComparsion == 1)
            {
                Console.WriteLine("Line1 length is greater than Line2");
            }
            else
            {
                Console.WriteLine("Line1 length is less than Line2");
            }
        }
    }
}
