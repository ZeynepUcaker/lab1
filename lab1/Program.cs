Console.Write("What is your name? ");
string name = Console.ReadLine();

Console.Write("Which city do you live in? ");
string city = Console.ReadLine();

Console.Write("What is your department? ");
string department = Console.ReadLine();

Console.Write("What is your grade year?");
string year = Console.ReadLine();

Console.WriteLine("Name: " + name);
Console.WriteLine("City: " + city);
Console.WriteLine("Department: " + department);
Console.WriteLine("Year: " + year);
Console.WriteLine("C# is fun!");
Console.WriteLine("Hello " + name + " from " + city + ", welcome to C#!");



Console.WriteLine("------------------------------------------");


Console.Write("First number: ");
double number1 = double.Parse(Console.ReadLine());

Console.Write("Second number: ");
double number2 = double.Parse(Console.ReadLine());

Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
Console.WriteLine($"{number1} / {number2} = {number1 / number2}");

Console.WriteLine("------------------------------------------");


Console.Write("Enter student name: ");
string studentName = Console.ReadLine();

Console.Write("Enter midterm score: ");
int midtermScore = int.Parse(Console.ReadLine());

Console.Write("Enter final score: ");
int finalScore = int.Parse(Console.ReadLine());

double average = (midtermScore * 0.4) + (finalScore * 0.6);

Console.WriteLine($"Student Name: {studentName},your average is {average:F2}");

if(average >= 50)
{
    Console.WriteLine("Result: PASSED");
}
else
{
    Console.WriteLine("Result: FAILED");
}


Console.WriteLine("------------------------------------------------------------");


Console.Write("Enter a 3-digit number: ");
int num = int.Parse(Console.ReadLine());

int hundreds = (num / 100);
int tens = (num / 10) % 10;
int ones = num % 10;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}"); 
Console.WriteLine($"Ones: {ones}");
Console.WriteLine($"Sum: {hundreds + tens + ones}");

if(num % 2 == 0)
{
      Console.WriteLine($"{num} is even.");
}
else
{
    Console.WriteLine($"{num} is odd.");

}

if (hundreds == ones)
{
    Console.WriteLine("First and last digits are the same.");
}
else
{
    Console.WriteLine("First and last digits are different.");
}


