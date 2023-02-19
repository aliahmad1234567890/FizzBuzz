using FizzBuzzLibrary;

var result = new FizzBuzz(new Dictionary<int, string> { { 5, "Fizz" }, { 9, "Buzz" }, { 27, "Bar" } },
    new Dictionary<int, int> { { 5, 5 }, { 9, 9 }, { 27, 27 } });
var response = result.GetFizzBuzzOutput(-20, 127);
Console.WriteLine(response);
