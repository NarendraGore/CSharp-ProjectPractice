using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class UsernamePassword
    {
        /*WAP  TO CHECK THAT USERNAME AND PASSWORD BOTH ARE CORRECT OR NOT WHERE USERNAME IS YOUR FIRST 
         NAME AND PASSWORD YOUR LASTNAME? PROVIDE SEPARATE MESSAGES FOR INVALID USERNAME, INVALID PASSWORD,
         INVALID USERNAME, AND PASSWORD?*/
        static void Main() { 
            string firstname,lastname,username,password;
            Console.Write("Enter your first Name: ");
            firstname = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your Last Name: ");
            lastname = Convert.ToString(Console.ReadLine());

            Console.Write("Enter your User Name: ");
            username = Convert.ToString(Console.ReadLine());
            Console.Write("Enter your Password: ");
            password = Convert.ToString(Console.ReadLine());

            if (username == firstname && password == lastname)
            {

                Console.Write("username & password is correct.");
            }
            else if (username != firstname && password == lastname)
            {
                Console.Write("username is incorrect .");
            }
            else if (username == firstname && password != lastname)
            {
                Console.Write("password is incorrect.");
            }
            else {
                Console.Write("username & password is incorrect.");

            }


        }
    }
}
