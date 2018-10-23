using System;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Joana\Desktop\weeks\PU_IntroCSharp_InClass_1801681062\PUInClassW3\CandyShop\files\students.txt");
            System.Console.WriteLine("Contents of student.txt = ");
            int CandyStudents = 0;
            foreach (string line in lines)
            {
                string[] elements = line.Split(' ');
                string FirstName = elements[1];
                string name = $"{FirstName} {elements[3]}";
                //Console.WriteLine("\t" + line);
                 
                int sum = 0;
                for (int i = 0; i < FirstName.Length; i++)
                {
                    sum += (int)FirstName[i];
                }
                if (sum>9000)
                {
                    Console.WriteLine($"Candy for {name} => {FirstName.Length}");
                    CandyStudents += 1;
                }
            }
            Console.WriteLine($"TOTAL LINES: {lines.Length}");
            Console.WriteLine($"Total candy students: {CandyStudents}");
        }
    }
}
