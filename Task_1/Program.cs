using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 1:
//Додаток дозволяє користувачеві переглядати вміст файлу. 
//Користувач вводить шлях до файлу. Якщо файл існує, його вміст 
//відображається на екрані. Якщо файл не існує, виведіть 
//повідомлення про помилку.
namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToDir = @"C:\FileSystem\HomeTask_12.10.23";
            string pathToFile = pathToDir + @"\Task_1.txt";
            if (!Directory.Exists(pathToDir))
            {
                Directory.CreateDirectory(pathToDir);
            }
            string mes = "Hello People! We are studing C#!";
            //if (!File.Exists(pathToFile))
            //{
            //    var file = File.Create(pathToFile);
            //    file.Close();
            //}
            File.WriteAllText(pathToFile, mes, Encoding.Unicode);

            Console.WriteLine("Enter path to file (C:\\\\FileSystem\\HomeTask_12.10.23\\Task_1.txt): ");
            string path = Console.ReadLine();
            //Console.WriteLine(path);
            if (!File.Exists(path))
            {
                Console.WriteLine("\nError! The File does not exist.");
            }
            else
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("\n\tThe File content: \n" + content);
            }
        }
    }
}
