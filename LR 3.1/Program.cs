using System;
using System.IO;
using System.Collections.Generic;


namespace Laba3._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {    Console.WriteLine("Введiть шлях до обраної папки: ");
            string dirName = String.Format(Console.ReadLine());

            List<string> ls = new List<string>();


            if (Directory.Exists(dirName))
            {
                try
                {   Console.WriteLine("\n Файли: ");
                    foreach (var f in Directory.GetFiles(dirName))
                    { 
                       
                        Console.WriteLine(Path.GetFileName(f));
                        
                    }
                    
                    Console.WriteLine("\n Пiдкаталоги: ");
                    foreach (var d in Directory.GetDirectories(dirName))
                    {   
                        Console.WriteLine(Path.GetFileName(d));
                        
                        Console.WriteLine("\n Файли пiдкаталогiв: ");
                        foreach (var g in Directory.GetFiles(d) )
                        { 
                            
                            Console.WriteLine(Path.GetFileName(g));
                        }
                        
                    }

                }
                catch(System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

    }
}
