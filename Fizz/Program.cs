using Fizz;

var fizz = new FizzBuzz();

var list = fizz.GetFizzBuzzSequence(1, 100);

foreach(var item in list)
{
    Console.WriteLine(item);
}