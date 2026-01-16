using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int UserNum = -1;
        while (UserNum != 0)
        {
            Console.WriteLine("Enter a number (0 to quit): ");

            string response = Console.ReadLine();
            UserNum = int.Parse(response);

            if (UserNum != 0)
            {
                numbers.Add(UserNum);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {avg}");


        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The Max is: {max}");
    }
}