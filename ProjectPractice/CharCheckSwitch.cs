using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class CharCheckSwitch
    {
        //WAP  to check entered char is numeric, alphabets, or special using switch? 

        static void Main() {
            char ch;
            Console.WriteLine("Enter a Char");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch) {

                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("Numeric Character");
                    break;

                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                case 'i':
                case 'j':
                case 'k':
                case 'l':
                case 'm':
                case 'n':
                case 'o':
                case 'p':
                case 'q':
                case 'r':
                case 's':
                case 't':
                case 'u':
                case 'v':
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    Console.WriteLine("Aphabetic character");
                    break;

                default:
                    Console.WriteLine("Special Character");
                    break;
                
            }
                
        }
    }
}
