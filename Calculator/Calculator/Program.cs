using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();
            Console.WriteLine("Enter y");
            int y = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            switch (op)
            {
                case "+":
                    result = x + y;
                    Console.WriteLine("Addition = " + result);
                    break;
                case "-":
                    result = x - y;
                    Console.WriteLine("Subtraction = " + result);
                    break;

                case "*":
                    result = x * y;
                    Console.WriteLine("Multiplication = " + result);
                    break;

                case "/":
                    if (y == 0)
                    {
                        Console.WriteLine("Err");
                    }
                    else
                    {
                        float dec = (float)x / (float)y;
                        Console.WriteLine("Division = " + dec);
                    }
                    break;

                case "%": //percent
                    float prc = (float)x * (float)y / (float)100;
                    Console.WriteLine(y + " percent of " + x + " = " + prc);
                    break;

                case "$": //Root
                    if (x < 0)
                    {
                        Console.WriteLine("Err");
                        break;
                    }
                    else if(x == 0 || x == 1)
                    {
                        Console.WriteLine("Root = " + x);
                        break;
                    }
                    else
                    {
                        int NearSquare = 0;
                        int NearSquareNum = 0;

                        for (int i = 0; i < x; i++)
                        {
                            int squreNum = 1;
                            for(int n = 0; n < y; n++)
                            {
                                squreNum *= i;
                            }
                            if (squreNum <= x)
                            {
                                NearSquare = squreNum;
                                NearSquareNum = i;
                            }
                        }
                        float root = (float)NearSquareNum + (((float)NearSquareNum / ((float)y * (float)NearSquare)) * ((float)x - (float)NearSquare));
                        Console.WriteLine("Root = " + root);
                    }


                    break;
            }
        }
    }
}
