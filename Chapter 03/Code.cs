using static System.Runtime.InteropServices.JavaScript.JSType;

int number = 15;
if (number < 20)
{
    Console.WriteLine("The number is less than 20");
}

if (number > 0)
{
    if (number < 50)
    {
        Console.WriteLine("The number is greater than 0 and less than 50");
    }
}

int number1 = 60;
if (number1> 0)
{
    if (number1 < 50)
    {
        Console.WriteLine("The number is between 0 and 50");
    }
    else
    {
        Console.WriteLine("The number is not between 0 and 50");
    }
}

int number2 = 6;
if (number2 >= 0)
{
    if (number2 % 3 == 0)
    {
        Console.WriteLine("The number is positive and divisible by 3");
    }
    else
    {
        Console.WriteLine("The number is positive and not divisible by 3");
    }
}
else
{
    Console.WriteLine("The number is negative");
}

int score = 85; // Example score

if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: C");
}
else if (score >= 60)
{
    Console.WriteLine("Grade: D");
}
else
{
    Console.WriteLine("Grade: F");
}

int day = 2;

switch (day)
{
    case 0:
        Console.WriteLine("This is Sunday");
        break;
    case 1:
        Console.WriteLine("This is Monday");
        break;
    case 2:
        Console.WriteLine("This is Tuesday");
        break;
    case 3:
        Console.WriteLine("This is Wednesday");
        break;
    case 4:
        Console.WriteLine("This is Thursday");
        break;
    case 5:
        Console.WriteLine("This is Friday");
        break;
    case 6:
        Console.WriteLine("This is Saturday");
        break;
    default:
        Console.WriteLine("Not a day of the week");
        break;
}

int i = 0;
for (i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}

int row = 5;
int column = 5;
int a = 1;
while (a <= row)
{
    int b = 1;
    while (b <= column)
    {
        Console.Write(" * ");
        b++;
    }
    Console.WriteLine();
    a++;
}

i = 1;
do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 5);

string[] vegetables = { "Tomato", "Potato", "Onion" };
foreach (string vegetable in vegetables)
{
    Console.WriteLine(vegetable);
}

char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
char goal = 'e';
bool present = false;
for (a = 0; a < letters.Length; a++)
{
    if (letters[a] == goal)
    {
        present = true;
        Console.WriteLine($"The letter {goal} is present at index {a}.");
        break;
    }
}
if (!present)
{
    Console.WriteLine($"The letter {goal} is not present in the array");
}

for (a = 1; a <= 20; a++)
{
    if (a % 2 == 0)
    {
        continue; // This statement will skip the iteration here if the current value of a is divisible by 2
    }
    Console.WriteLine(a);
}

int Sum(int x, int y)
{
    return x + y; // The return statement is used to send the sum to the caller
}
number1 = 4;
number2 = 6;
int addition = Sum(number1, number2); // This is the caller
Console.WriteLine($"{number1} + {number2} = {addition}");

Console.WriteLine("This line is before the 'goto' statement");
goto Label;
Console.WriteLine("This line will be skipped");
Label:
Console.WriteLine("This line is after the 'goto' statement");

try
{
    int[] integers = { 5, 6, 7 };
    Console.WriteLine(integers[4]); // This line produces an error that the index is out of range
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

try
{
    // This block has the code that can potentially throw different exceptions
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

try
{
    // This block has the code that can potentially throw different exceptions
}
catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("This line of code will be executed irrespective of the try-catch block");
}

void Division(int dividend, int divisor)
{
    if (divisor == 0)
    {
        throw new DivideByZeroException("divisor must be non-zero");
    }
    Console.WriteLine($"{ dividend}/{ divisor} = { dividend / divisor}");
}

try
{
    Division(10, 2); // Valid division
    Division(10, 0); // Invalid division, will throw exception
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: { ex.Message}");
}






