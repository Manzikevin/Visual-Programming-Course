using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter marks for 5 courses.");
            int sum = 0, average, marks;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Enter Marks for course {i}:");
                marks = int.Parse(Console.ReadLine());

                if (marks >= 0 && marks <= 100)
                {
                    sum += marks;
                }
                else
                {
                    Console.WriteLine("Invalid input (must be between 0 and 100).");
                }
            }
            
            average = sum / 5;

            Console.WriteLine($"\nTotal Sum: {sum}");
            Console.WriteLine($"Average: {average}");

            if (average >= 80)
            {
                Console.WriteLine("First Class");
            }
            else if (average >= 70)
            {
                Console.WriteLine("First Lower Class");
            }
            else if (average >= 60)
            {
                Console.WriteLine("Second Lower Class");
            }
            else if (average >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("No Diploma Awarded");
            }
        }
    }
}