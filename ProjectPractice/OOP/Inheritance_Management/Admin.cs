using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPractice.OOP.Inheritance_Management
{
    internal class Admin
    {
        internal int id;
        internal string name;

        internal void GetAdminData() {
            Console.Write("Enter Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Convert.ToString(Console.ReadLine());
        
        }
        internal void ShowAdminData() {
            Console.WriteLine("Id: "+id);
            Console.WriteLine("Name:"+name);
        }
    }
}
