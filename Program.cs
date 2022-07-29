using System;
namespace LineComparisionProblem
{

    public class LineComparision
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Project");

            double line1 = 0, line2 = 0;
            int x1 = 0, x2, y1, y2;
            for (int i = 0; i<2; i++)
            {
                if (i==0)
                {
                    Console.WriteLine("Enter 1st Line Coordinates in the order X1,X2,Y1 and Y2");
                    x1=int.Parse(Console.ReadLine());
                    x2=int.Parse(Console.ReadLine());
                    y1=int.Parse(Console.ReadLine());
                    y2=int.Parse(Console.ReadLine());

                    line1=(Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)));
                }
                if (i==1)
                {
                    Console.WriteLine("Enter 2nd Line Coordinates in the order X1,X2,Y1 and Y2");
                    x1=int.Parse(Console.ReadLine());
                    x2=int.Parse(Console.ReadLine());
                    y1=int.Parse(Console.ReadLine());
                    y2=int.Parse(Console.ReadLine());

                    line2=(Math.Sqrt(Math.Pow((x2-x1), 2)+Math.Pow((y2-y1), 2)));
                }


            }

            if (line1==line2)
                Console.WriteLine("Both Lines are equal");
            else
                Console.WriteLine("Both Lines are not equal");
        }
    }
}