using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_15
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string: ");
            string text = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(@"C:\Users\student\Desktop\myFile.txt", true, Encoding.Default))
            {
                sw.WriteLine(text);
            }

            List<string> list = new List<string>();

            using (StreamReader sr = new StreamReader(@"C:\Users\student\Desktop\myFile.txt", Encoding.Default))
            {
                string s;
                do
                {
                    s = sr.ReadLine();
                    if (s != null)
                        list.Add(s);
                }
                while (s != null);
                
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //using (FileStream filestream = new FileStream(@"C:\Users\student\Desktop\myFile.txt", FileMode.OpenOrCreate))
            //    {
            //        byte[] array = Encoding.Default.GetBytes(text);
            //        filestream.Write(array, 0, array.Length);
            //        Console.WriteLine("Done");
            //    }

            //using (FileStream filestr = File.OpenRead(@"C:\Users\student\Desktop\myFile.txt"))
            //{
            //    byte[] array = new byte[filestr.Length];
            //    filestr.Read(array, 0, array.Length);
            //    string text2 = Encoding.Default.GetString(array);
            //    Console.WriteLine(text2);
            //}

        }
    }
}
