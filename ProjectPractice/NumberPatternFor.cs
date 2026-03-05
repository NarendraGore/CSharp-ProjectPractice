using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class NumberPatternFor
    {
        static void Main()
        {
            /*Number Pattern For
             12345
             5432
             123
             54
             1
             */

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 6 - i; j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(6 - j);
                    }
                }
                Console.WriteLine();

            }

            /*
             Char Pattern
            AaBbC
            AaBb
            AaB
            Aa
            A
             */

            for (int i = 1; i <= 5; i++)
            {

                char ch = 'A';
                for (int j = 1; j <= 6 - i; j++)
                {


                    if (j % 2 != 0)
                    {
                        Console.Write(ch);
                    }
                    else
                    {
                        Console.Write((char)(ch + 32));
                        ch++;

                    }


                }
                Console.WriteLine();
            }


            /*
              *
             ***
            *****

             */

            for (int i = 1; i <= 5; i++)
            {
                for (int space = 4; space >= i; space--)
                {
                    Console.Write(" ");

                }
                for (int j = 1; j <= 2 * i- 1; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

            /*
              *
             ***
            *****
             ***
              *
             
             */
            Console.WriteLine("New Pattern");
            int n = 3;
            for (int i = 1; i <= n; i++)
            {
                for (int space = i; space <n; space++) { 
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++) {
                    Console.Write("*");
                
                }
                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--) {


                for (int space = n; space > i; space--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            /*
             12345
              1234
               123
                12
                 1*/
            int n1 = 5;

            for (int i = 1; i <= n1; i++) {
                for (int space =0; space < i; space++) { 
                    Console.Write(" ");
                }
                for (int j = 1; j <= 6-i; j++) { 
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }


    }
}