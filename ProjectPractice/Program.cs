using System;
using System.Data;
using System.Security.Cryptography;
using System.Transactions;
using ProjectPractice.Collections;
using ProjectPractice.Interface;
using ProjectPractice.OOP;
using ProjectPractice.OOP.Abstraction;
using ProjectPractice.OOP.AccessSpecifiers;
using ProjectPractice.OOP.FileHandling;
using ProjectPractice.OOP.Inheritance_Area;
using ProjectPractice.OOP.Inheritance_Management;
using ProjectPractice.OOP.Overriding;

namespace ProjectPractice {

    internal class Program:AccessSpecifiers {

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

            //  BoxingExample example = new BoxingExample ();
            //example.boxingfun();
            //example.Unboxingfun();

            //Data Types

            //DataType data = new DataType ();

            //data.PDataType();
            //data.DDataType();


            /* //Employee Class Access
                       Class_Obj emp = new Class_Obj ();
                        emp.Accept(1,"ABC",40000);
                        emp.Display();

                        Class_Obj emp1 = new Class_Obj ();
                        emp.Accept(2, "DEF", 45000);
                        emp.Display();*/

            /*Student Data Display


            StudentMarks[] std = new StudentMarks[2];
            for (int i = 0; i < std.Length; i++) {
                std[i] = new StudentMarks();
                Console.Write("Enter Roll Number:");
                int rno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name:");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Enter Marks:");
                int marks = Convert.ToInt32(Console.ReadLine());
                std[i].Accept(rno, name, marks);
            }


            int max = 0;
            int stdIndex = 0;
            for (int i = 0; i < std.Length; i++) {
                if (max < std[i].stdMarks)
                {
                    max= std[i].stdMarks;
                    stdIndex = i;
                }

            }
            Console.WriteLine("Maximum Marks are:{0}", max);
            std[stdIndex].Display();*/


            /*Member Function Types

            MemberFunction obj1=  new MemberFunction();
            obj1.fun();
            Console.WriteLine(obj1.fun2());
            obj1.fun3(5);
            Console.WriteLine(obj1.fun4(6));

            */

            /*Constructor Example


            ConstructorExample example = new ConstructorExample(10, 20);
            ConstructorExample example1 = new ConstructorExample(example);
            */
            /*Property Example 
            PropertyExample example = new PropertyExample();
            example.Width = 100;
            Console.WriteLine("Property example:"+example.Width);*/

            /*OverLoading Example | PolyMorphism

            OverLoadingExample example = new OverLoadingExample();
            example.Add(1, 2);
            example.Add(2, 3,5);
            example.Add(2.15f, 22.85f);
            */

            /*Inheritance Example | Single | Multilevel | Hirarchical

            B obj1 = new B();
            obj1.fun2();
            obj1.fun1();

            C obj2 = new C();
            obj2.fun3();
            obj2.fun2();
            obj2.fun1();*/

            /*Inheritance Assignment | Area of circle | Rectangle | Triangle

            //Circle obj1 = new Circle();
            //obj1.Accept1(5);
            //obj1.CircleArea();
            //obj1.Display();

            Rectangle obj2 = new Rectangle();
            obj2.Accept1(5);
            obj2.Accept2(6);
            obj2.CircleArea();
            obj2.Display();
            obj2.RectangleArea();
            obj2.Display();

            Triangle obj3 = new Triangle();
            obj3.Accept1(5);
            obj3.Accept2(6);
            obj3.TriangleArea();
            obj3.Display();*/


            /*Inheritance Assignment | Admin | Manager | Employee

                        Employee emp = new Employee();
                        emp.GetEmployeeData();
                        Console.WriteLine("\n Employee Details:");
                        emp.ShowEmployeeData();*/

            /*Abstraction  | AbstractArea | AbstractChildArea

            AbstractArea area = new AbstractChildArea();
            area.Accept(10, 20);
            area.triangle();
            area.Display();

            AbstractArea area1 = new AbstractChildArea();
            area1.Accept(10, 20); 
            area1.rectangle();
            area1.Display();*/

            /*Acceess Specifiers | private | internal | protected | protected internal | public 
            
            Program obj3 = new Program();
            obj3.fun2();
            obj3.fun3();
            obj3.fun4();
            obj3.fun5();
            */

            /*Interface Implement | 
            IFirst first = new InterfaceImplement();
            first.fun1();
            first.fun2();
            ISecond second = new InterfaceImplement();
            second.fun1();
            second.fun2();
            second.fun3();*/

            /*Overriding */
            Bill bill = new GSTBill();
            Console.WriteLine(bill.CalcBill(1000));

            /*Overhiding*/
            Bill bill1 = new GSTBill();
            bill1.CalcBill(1000);
            Console.WriteLine(bill1.CalcBill(1000));

            /*File Operations | Create File | Write File | Read File |Append File
            FileOperations fs = new FileOperations();
            //fs.CreateFile();
            //fs.AddContentOnFile();
            //fs.AppendContentOnFile();
            //fs.ReadContentOnFile();
            fs.DeleteFileOperation();*/

            /*Collections*/
            
            ArrayListExample example = new ArrayListExample();
            example.HashTableFun();
        }

}
}