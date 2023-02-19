namespace FizzBuzzLibrary
{
    using System.Collections.Generic;

    public class FizzBuzz
    {
        private readonly Dictionary<int, string> _tokens;
        private readonly Dictionary<int, int> _divisors;

        public FizzBuzz(Dictionary<int, string> tokens, Dictionary<int, int> divisors)
        {
            // custom tokens and divisors
            _tokens = tokens;
            _divisors = divisors;
        }

        public string GetFizzBuzzOutput(int start, int end)
        {
            var result = "";
            for (var i = start; i <= end; i++)
            {
                result += GetFizzBuzzValue(i) + "\n";
            }
            return result;
        }

        public string GetFizzBuzzOutput(params int[] numbers)
        {
            var result = "";
            foreach (var number in numbers)
            {
                result += GetFizzBuzzValue(number) + "\n";
            }
            return result;
        }

        private string GetFizzBuzzValue(int number)
        {
            var value = "";
            foreach (var divisor in _divisors)
            {
                if (number % divisor.Value == 0)
                {
                    value += _tokens[divisor.Key];
                }
            }
            if (string.IsNullOrEmpty(value))
            {
                value = number.ToString();
            }
            return value;
        }
    }
}