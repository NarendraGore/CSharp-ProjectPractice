using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ProjectPractice.Collections
{
    internal class ArrayListExample
    {
        internal void ArrayListFun()
        { 
        ArrayList list = new ArrayList();
           list.Add(1);
            list.Add("sdfsdfs");
            list.Add(12.55f);
            Console.WriteLine("Display data using for loop:");
            for (int i = 0; i < list.Count; i++) { 
            
            Console.WriteLine(list[i]);
            }
            Console.WriteLine("Display data using for each loop:");

            foreach (object o in list) { 
                Console.WriteLine("data is {0}",o);
            }

        }

        internal void HashTableFun() { 
        
        Hashtable o = new Hashtable();
            o.Add("name", "xyz");
            o.Add("id",1);
            o.Add("city","pune");

            foreach (DictionaryEntry obj in o) {


                Console.WriteLine("key is {0} and value is {1}",obj.Key,obj.Value);

            }
        }



      
        
    }
}
