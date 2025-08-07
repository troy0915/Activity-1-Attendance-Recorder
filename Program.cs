using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1_Attendance_Recorder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string input;

            Console.WriteLine("Enter student names (type 'done' to finish):");
            while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }

                names.Add(input);
            }
            for (int i = 0; i < names.Count; i++)
            {
                names[i] = names[i].ToUpper();
            }
            Console.WriteLine("\nNames in uppercase:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            int countA = 0;
            foreach (var name in names)
            {
                if (name.StartsWith("A"))
                {
                    countA++;
                }
            }
            Console.WriteLine($"\nNumber of names starting with 'A': {countA}");
        }
    }
}







