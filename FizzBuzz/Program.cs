int[] numbers = Enumerable.Range(1, 100).ToArray();


foreach (var number in numbers)
{
	string word = "";

	if(number % 3 == 0) word += "Fizz";
	if(number % 5 == 0) word += "Buzz";

	if(string.IsNullOrEmpty(word)) word = number.ToString();

	Console.WriteLine(word);
}

Console.ReadLine();
