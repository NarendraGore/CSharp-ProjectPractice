using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice
{
    internal class MarksheetCalculate
    {
        /*
 WAP to Calculate Marksheet using five different subjects with the following condition.

1) all subject marks should be 0 to 100.

2) if only one subject mark is <33 then the student will be suppl.

3) if all subject marks are >=33 then percentage and division should be calculated.

4) if a student is suppl then five bonus marks can be applied to be pass and the result will be "pass by grace".

5) Display Grace Subject name, distinction subject name,suppl subject name, and failed subject name.

*/
        static void Main()
        {

            double phmarks, chmarks, mathmarks, biomarks, engmarks;
            Console.Write("Enter the Physics Marks:");
            phmarks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Chemistry Marks:");
            chmarks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Math Marks:");
            mathmarks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Biology Marks:");
            biomarks = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the English Marks:");
            engmarks = Convert.ToDouble(Console.ReadLine());


            if (phmarks < 0 || phmarks > 100 ||
                chmarks < 0 || chmarks > 100 ||
                mathmarks < 0 || mathmarks > 100 ||
                biomarks < 0 || biomarks > 100 ||
                engmarks < 0 || engmarks > 100)
            {

                Console.WriteLine("Enter valid marks, marks between 0 to 100");

            }
            else
            {
                int failcount = 0;
                string supplSubject = "";
                //string graceSubject = "";
                string failedSubject = "";

                if (phmarks < 33) { failcount++; supplSubject = "physics"; }
                ;
                if (chmarks < 33) { failcount++; supplSubject = "chemistry"; }
                ;
                if (mathmarks < 33) { failcount++; supplSubject = "math"; }
                ;
                if (biomarks < 33) { failcount++; supplSubject = "biology"; }
                ;
                if (engmarks < 33) { failcount++; supplSubject = "english"; }
                ;


                double totalmarks = phmarks + chmarks + mathmarks + biomarks + engmarks;


                if (failcount > 1)
                {
                    Console.WriteLine("Result : FAIL");
                    if (phmarks < 33) { Console.WriteLine("Failed Subject: physics"); }
                    ;
                    if (chmarks < 33) { Console.WriteLine("Failed Subject: chemistry"); }
                    ;
                    if (biomarks < 33) { Console.WriteLine("Failed Subject: biology"); }
                    ;
                    if (mathmarks < 33) { Console.WriteLine("Failed Subject: Math"); }
                    ;
                    if (engmarks < 33) { Console.WriteLine("Failed Subject: English"); }
                    ;
                }
                else
                {

                    if (failcount == 1)
                    {

                        Console.WriteLine("Result :SUPPLEMENTARY");
                        Console.WriteLine("Supplementary subject is:" + supplSubject);

                        if (supplSubject == "physics") { phmarks = phmarks + 5; }
                        if (supplSubject == "chemistry") { chmarks = chmarks + 5; }
                        if (supplSubject == "math") { mathmarks = mathmarks + 5; }
                        if (supplSubject == "biology") { biomarks = biomarks + 5; }
                        if (supplSubject == "english") { engmarks = engmarks + 5; }

                        if ((supplSubject == "physics" && phmarks >= 33) ||
                       (supplSubject == "chemistry" && chmarks >= 33) ||
                       (supplSubject == "math" && mathmarks >= 33) ||
                       (supplSubject == "biology" && biomarks >= 33) ||
                       (supplSubject == "english " && engmarks >= 33))
                        {
                            Console.WriteLine("Grace Applied in: " + supplSubject);
                            Console.WriteLine("Result: PASS BY GRACE");
                            totalmarks = phmarks + chmarks + mathmarks + biomarks + engmarks;
                        }
                        else
                        {
                            Console.WriteLine("Result: FAIL");
                            failedSubject = supplSubject;
                            Console.WriteLine("Failed Subject: " + failedSubject);
                            return;
                        }
                    }

                }



                double percentage = totalmarks / 5.0;

                Console.WriteLine("Total Marks:"+totalmarks);
                Console.WriteLine("percentage:"+percentage+"%");

                if (percentage > 75)
                {
                    Console.WriteLine("Division:Distinction");
                }
                else if (percentage > 60)
                {
                    Console.WriteLine("Division :First Division");
                }
                else if (percentage > 50)
                {
                    Console.WriteLine("Division:Second Division");
                }
                else {
                    Console.WriteLine("Division:Third Division");

                }

                if (phmarks >= 75) { Console.WriteLine("Distincion Subject:" + phmarks); }
                if (chmarks>= 75) { Console.WriteLine("Distincion Subject:" + chmarks); }
                if (mathmarks >= 75) { Console.WriteLine("Distincion Subject:" + mathmarks); }
                if (biomarks >= 75) { Console.WriteLine("Distincion Subject:" + biomarks); }
                if (engmarks >= 75) { Console.WriteLine("Distincion Subject:" + engmarks); }

            }
        }


        }
    }

