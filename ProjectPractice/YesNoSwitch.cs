using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class YesNoSwitch
    {

        //WAP to display "yes", "no" and "cancel" when user assign 'y','n', and 'c'?
        static void Main() {
            char ch;
            Console.WriteLine("Enter y/n/c");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch) {
                case 'y':
                    Console.WriteLine("Yes");
                    break;
                case 'n':
                    Console.WriteLine("No");
                    break;
                case 'c':
                    Console.WriteLine("Cancel");
                    break;
            }
                }
    }
}
