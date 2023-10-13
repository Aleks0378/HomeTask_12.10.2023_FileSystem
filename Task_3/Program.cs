using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3:
//Додайте до другого завдання можливість завантажувати масив 
//із файлу.
namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToDir = @"C:\FileSystem\HomeTask_12.10.23";
            string pathToFile = pathToDir + @"\Task_2.txt";
            if (!Directory.Exists(pathToDir))
            {
                Directory.CreateDirectory(pathToDir);
            }
            if (!File.Exists(pathToFile))
            {
                var file = File.Create(pathToFile);
                file.Close();
            }

            Console.Write("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter {i + 1} integer number: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int i in arr)
            {
                if (i == arr[0]) File.AppendAllText(pathToFile, $"[ {i},", Encoding.Unicode);
                else if (i == arr[arr.Length - 1]) File.AppendAllText(pathToFile, $"{i} ]", Encoding.Unicode);
                else File.AppendAllText(pathToFile, $"{i},", Encoding.Unicode);
            }
            Console.WriteLine("The File content: " + File.ReadAllText(pathToFile));
        }
    }
}
