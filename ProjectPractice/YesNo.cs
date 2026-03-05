using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class YesNo
    {
        static void Main() {

            //WAP to display "YES" and "NO" when the user press 'y' and 'n'?
            char ch;
            Console.WriteLine("Enter a `y` or `n` to print `yes` or `no`");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'y' || ch == 'Y')
            {
                Console.WriteLine("Yes");
            }
            else if (ch == 'n' || ch == 'N')
            {
                Console.WriteLine("No");

            }
            else {
                return;
            }
        }
        
    }
    
}
