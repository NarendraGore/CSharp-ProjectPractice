using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Exception_Handling
{
    internal class NegativeNumberException : Exception
    {
        private string _message = "Enter a +ve Number";
        public String Message
        {
            get
            {
                return _message;

            }
        }
    }
}
        