using FizzBuzzLibrary;

var result = new FizzBuzz(new Dictionary<int, string> { { 3, "Fizz" }, { 5, "Buzz" } },
    new Dictionary<int, int> { { 3, 3 }, { 5, 5 } });
var response = result.GetFizzBuzzOutput(1, 100);
Console.WriteLine(response);

