using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 4:
//Додаток генерує випадковим чином 10000 цілих чисел. 
//Збережіть парні числа в один файл, непарні – в інший. За 
//підсумками роботи додатка потрібно відобразити статистику на 
//екрані.

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToDir = @"C:\FileSystem\HomeTask_12.10.23";
            string pathToFileEven = pathToDir + @"\Task_4_Even.txt";
            string pathToFileOdd = pathToDir + @"\Task_4_Odd.txt";
            if (!Directory.Exists(pathToDir))
                Directory.CreateDirectory(pathToDir);
            if (File.Exists(pathToFileEven))
                File.WriteAllText(pathToFileEven,"");
            if (File.Exists(pathToFileOdd))
                File.WriteAllText(pathToFileOdd, "");
            Random rand = new Random();
            int n = 0, countEven = 0, countOdd = 0;

            Console.WriteLine("Random numbers: ");
            for (int i = 0;i<10000;i++)
            {
                n=rand.Next(0,50);
                Console.Write($"{n}, ");
                if (n % 2 == 0)
                {
                    File.AppendAllText(pathToFileEven, $"{n}, ", Encoding.Unicode);
                    countEven++;
                }
                else
                {
                    File.AppendAllText(pathToFileOdd, $"{n}, ", Encoding.Unicode);
                    countOdd++;
                }
            }
            Console.WriteLine($"\n\nAll Even numbers recorded to the file (Total {countEven}): ");
            Console.WriteLine(File.ReadAllText(pathToFileEven));
            Console.WriteLine($"\nAll Odd numbers recorded to the file (Total {countOdd}): ");
            Console.WriteLine(File.ReadAllText(pathToFileOdd));
        }
    }
}
