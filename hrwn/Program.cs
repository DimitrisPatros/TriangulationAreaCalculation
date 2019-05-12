using System;

namespace hrwn
{
    class Program
    {
        static void Main(string[] args)
        {

            bool doContinue;

            do
            {
                DoWork();
                Console.WriteLine("Do you want to calculate another tringle? (y/n)");
                char response = char.Parse(Console.ReadLine());
                if (response == 'y')
                {
                    doContinue = true;
                }
                else
                {
                    doContinue = false;
                    Console.WriteLine("thank you for the input");
                }

            } while (doContinue);
        }

        static void DoWork()
        {
            //INPUT
            Console.WriteLine("give the size of the first side in cm : ");
            double sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("give the size of the second side in cm : ");
            double sideB = double.Parse(Console.ReadLine());
            Console.WriteLine("give the size of the third side in cm : ");
            double sideC = double.Parse(Console.ReadLine());

            //PROCESSING
            double area = areaCalculationByHronformula(sideA, sideB, sideC);
            
            //OUTPUT
            Console.WriteLine("area of the trinagle in cm^2 is : {0} ", area);
         }

        static double areaCalculationByHronformula(double sideA, double sideB, double sideC)
        {
            double hronone;
            double area;
            hronone = (sideA + sideB + sideC) / 2;
            area = Math.Sqrt(hronone * (hronone - sideA) * (hronone - sideB) * (hronone - sideC));
            return area;

        }
    }
}
