using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers seperated by commas please");
            var stringList = Console.ReadLine();

            // Converting string into list by splitting on comma. .Select projects each element of a sequence into a new form.
            var numbers = stringList.Split(',').Select(Int32.Parse).ToList();

            Console.WriteLine("Multiply, square, add, divide? Enter *, ^, + or /");
            var response = Console.ReadLine();

            switch(response)
            {
                case "*":
                    int result = numbers[0];
                    for (var i = 1; i < numbers.Count; i++)
                    {
                        result *= numbers[i];

                    }
                    Console.WriteLine(result);
                    break;
                case "^":
                    var resultList = new List<int>();
                    for (var i = 0; i < numbers.Count; i++)
                    {
                        resultList.Add(numbers[i] * numbers[i]);
                    }
                    var stringResult = string.Join(",", resultList);
                    Console.WriteLine(stringResult);
                    break;
                case "+":
                    int answer = numbers[0];
                    for (var i = 1; i < numbers.Count; i++)
                    {
                        answer += numbers[i];
                    }
                    Console.WriteLine(answer);
                    break;
                case "/":
                    double final = numbers[0];
                    for (var i = 1; i < numbers.Count; i++)
                    {

                        final /= numbers[i];

                    }
                    Console.WriteLine(final);
                    break;
                default: Console.WriteLine("That's not an option");
                    break;
            }
        }
    }
}
