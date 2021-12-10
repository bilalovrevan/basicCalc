using System;

namespace MyHelpers
{
    public class Class1
    {
      
        
            public void Main(string[] args)
            {
            step1:
                Console.WriteLine("emeliyyati secin (+,-,*,/): ");
                string @operator = Console.ReadLine();
                Console.WriteLine("1ci ededi daxil edin");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2ci ededi daxil edin");
                int b = Convert.ToInt32(Console.ReadLine());
                if (@operator == "+")
                {
                    Console.WriteLine($"Cavab:{toplama(a, b)}");
                }
                else if (@operator == "-")
                {
                    Console.WriteLine($"Cavab:{cixma(a, b)}");
                }
                else if (@operator == "*")
                {
                    Console.WriteLine($"Cavab:{vurma(a, b)}");
                }
                else if (@operator == "/")
                {

                    if (b == 0)
                    {
                        Console.WriteLine("mexrec sifirdan ferqli olmalidir");
                        goto step1;
                    }
                    else
                    {
                        Console.WriteLine($"Cavab:{nisbet(a, b)}");
                    }
                }
                else
                {
                    Console.WriteLine("emeliyyati duzgun secin");
                }
            }
            static string toplama(int a, int b)
            {
                int c = a + b;
                string d = Convert.ToString(c);
                return d;
            }
            static int cixma(int a, int b)
            {
                int c = a - b;

                return c;
            }
            static int vurma(int a, int b)
            {
                int c = a * b;

                return c;
            }
            static double nisbet(double a, double b)
            {
                double c = a / b;

                return c;
            }

        }
    
}
