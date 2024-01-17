using System;

namespace exercises_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Tests for IsCentered function *********");
            Console.WriteLine($"Result Expected: 0 - Result Received: {IsCentered([1, 2, 3, 4, 5])}");
            Console.WriteLine($"Result Expected: 1 - Result Received: {IsCentered([3, 2, 1, 4, 5])}");
            Console.WriteLine($"Result Expected: 0 - Result Received: {IsCentered([3, 2, 1, 4, 1])}");
            Console.WriteLine($"Result Expected: 0 - Result Received: {IsCentered([1, 2, 3, 4])}");
            Console.WriteLine($"Result Expected: 0 - Result Received: {IsCentered([])}");
            Console.WriteLine($"Result Expected: 1 - Result Received: {IsCentered([10])}");

            Console.WriteLine();
            Console.WriteLine("********* Tests for ReverseInteger function *********");
            Console.WriteLine($"Result Expected: 4321   - Result Received: {ReverseInteger(1234)}");
            Console.WriteLine($"Result Expected: 50021  - Result Received: {ReverseInteger(12005)}");
            Console.WriteLine($"Result Expected: 1      - Result Received: {ReverseInteger(1)}");
            Console.WriteLine($"Result Expected: 1      - Result Received: {ReverseInteger(1000)}");
            Console.WriteLine($"Result Expected: 0      - Result Received: {ReverseInteger(0)}");
            Console.WriteLine($"Result Expected: -54321 - Result Received: {ReverseInteger(-12345)}");

            Console.WriteLine();
            Console.WriteLine("********* Tests for CalculateDifference function *********");
            Console.WriteLine($"Result Expected:  1 - Result Received: {CalculateDifference([1])}");
            Console.WriteLine($"Result Expected: -1 - Result Received: {CalculateDifference([1, 2])}");
            Console.WriteLine($"Result Expected:  2 - Result Received: {CalculateDifference([1, 2, 3])}");
            Console.WriteLine($"Result Expected: -2 - Result Received: {CalculateDifference([1, 2, 3, 4])}");
            Console.WriteLine($"Result Expected: -2 - Result Received: {CalculateDifference([3, 3, 4, 4])}");
            Console.WriteLine($"Result Expected:  0 - Result Received: {CalculateDifference([3, 2, 3, 4])}");
            Console.WriteLine($"Result Expected: -2 - Result Received: {CalculateDifference([4, 1, 2, 3])}");
            Console.WriteLine($"Result Expected:  2 - Result Received: {CalculateDifference([1, 1])}");
            Console.WriteLine($"Result Expected:  0 - Result Received: {CalculateDifference([])}");
        }

        static int IsCentered(int[] input)
        {
            if (input == null || input.Length % 2 == 0) return 0;

            int middleIndex = input.Length / 2;
            int middleValue = input[middleIndex];

            for (int i = 0; i < input.Length; i++)
            {
                if (i != middleIndex && input[i] <= middleValue) return 0;
            }

            return 1;
        }

        static int ReverseInteger(int input)
        {
            int reversedInput = 0;

            while (input != 0)
            {
                int lastDigit = input % 10;

                reversedInput = (reversedInput * 10) + lastDigit;

                input /= 10;
            }

            return reversedInput;
        }

        static int CalculateDifference(int[] input)
        {
            int totalOdds = 0;
            int totalEvens = 0;

            foreach (var number in input)
            {
                if (number % 2 == 0)
                {
                    totalEvens += number;
                }
                else
                {
                    totalOdds += number;
                }
            }

            return totalOdds - totalEvens;
        }
    }
}
