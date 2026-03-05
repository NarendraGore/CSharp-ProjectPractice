using System;
using System.Data;

namespace ProjectPractice {

    internal class Program {

        static void Main(string[] args) {

            //Hello obj = new Hello();
            //obj.Accept();
            //obj.Add();
            //obj.Sub();
            //obj.Mult();
            //obj.Div();

            SI obj = new SI();
            obj.CalcSI();

            SwapNumber.swap();

            //Compound Interest;

            //CompoundInterest CI = new CompoundInterest();
            //CI.Accept();
            //CI.FinalAmount();

            //Area of a Circle

            //AreaOfCircle AC = new AreaOfCircle();
            //AC.Accept();
            //AC.AreaCircle();

            //Area of Triangle;

            //AreaOfTriangle AT = new AreaOfTriangle();
            //AT.Accept();
            //AT.areaTriangle();

            //Feet to inch;

            //FeetToInch Inch = new FeetToInch();
            //Inch.Accept();
            //Inch.GetInch();

            //Inch to Feet

            //InchToFeet Feet = new InchToFeet();
            //Feet.Accept();
            //Feet.GetFeet();

            //Three Digit Reverse Number;

            //ReverseNumber reverse = new ReverseNumber();
            //reverse.Accept();
            //reverse.GetReverseNumber();

            //Boxing Example

              BoxingExample example = new BoxingExample ();
            example.boxingfun();
            example.Unboxingfun();

            //Data Types

            DataType data = new DataType ();

            data.PDataType();
            data.DDataType();

    
        }

    }
}