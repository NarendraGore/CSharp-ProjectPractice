using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ProjectPractice.OOP.FileHandling
{
    internal class FileOperations
    {
        string path = "E:\\C# Learning/Hello.txt";

        internal void CreateFile()
        {
            try
            {

                if (File.Exists(path))
                {
                    Console.WriteLine("File already exists...");
                }
                else
                {
                    FileStream fs = File.Create(path);

                    fs.Close();
                    Console.WriteLine("File Created Successfully");
                }
            }
            catch(Exception e) {
                Console.WriteLine(e.Message.ToString());
            }

        }

        internal void AddContentOnFile()
        {
            try
            {
                StreamWriter fw = new StreamWriter(path);
                fw.WriteLine("Welcome in file Handling Concept...");
                fw.Close();
                Console.WriteLine("File content add Successfully...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }

        internal void AppendContentOnFile()
        {
            try
            {
                StreamWriter fw = new StreamWriter(path, true);
                fw.WriteLine("File Append SUccessfully...");
                fw.Close();
                Console.WriteLine("Content Append Successfully...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }

        }

        internal void ReadContentOnFile()
        {
            try
            {
                StreamReader streamReader = new StreamReader(path);
                string data = streamReader.ReadToEnd();
                Console.WriteLine(data);
                streamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
        internal void DeleteFileOperation()
        {
            try
            {
                File.Delete(path);
                Console.WriteLine("File Deleted Successfully");
            }
             catch(Exception e) {
     Console.WriteLine(e.Message.ToString());
 }

        }
    }
}
