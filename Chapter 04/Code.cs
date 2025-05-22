int CalculateProduct(int x, int y)
{
    int product = x * y;
    return product;
}

int multiply = CalculateProduct(5, 6);
Console.WriteLine($"Result: {multiply}");

void PrintWelcome(string Name)
{
    Console.WriteLine($"Hello {Name}!");
}

PrintWelcome("John");

bool IsEven(int number)
{
    return number % 2 == 0;
}
Console.WriteLine(IsEven(5));

// Method that uses value parameter
void ValueParameterExample(int number)
{
    number = 10; // This change will not affect the original variable
    Console.WriteLine($"Inside ValueParameterExample: {number}");
}

// Method that uses ref parameter
void RefParameterExample(ref int number)
{
    number = 20; // This change will affect the original variable
    Console.WriteLine($"Inside RefParameterExample: {number}");
}

// Method that uses out parameter
void OutParameterExample(out int number)
{
    number = 30; // The out parameter must be assigned before the method ends
    Console.WriteLine($"Inside OutParameterExample: {number}");
}

// Method that uses params parameter
void ParamsParameterExample(params int[] numbers)
{
    Console.WriteLine("Inside ParamsParameterExample:");
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}

int a = 5;

// Using value parameter
Console.WriteLine($"Before ValueParameterExample: {a}");
ValueParameterExample(a);
Console.WriteLine($"After ValueParameterExample: {a}");

// Using ref parameter
Console.WriteLine($"Before RefParameterExample: {a}");
RefParameterExample(ref a);
Console.WriteLine($"After RefParameterExample: {a}");

// Using out parameter
int b; // No need to initialize before passing to out parameter
OutParameterExample(out b);
Console.WriteLine($"After OutParameterExample: {b}");

// Using params parameter
ParamsParameterExample(1, 2, 3, 4, 5);

void PrintNote(string note)
{
    Console.WriteLine(note);
}

void DisplayTheTotal()
{
    int x = 6; // Definition and initialization at the same time
    int y; // Definition without initialization
    y = 6; // Later Initialization    
    int total = x + y; // Local variables are used
    Console.WriteLine($"The total = {total}");
}

void PerformOperation(int data)
{
    Console.WriteLine(data); // Here ‘data’ is a parameter of type ‘int’
} // Here the parameter ‘data’ is out of scope

void TestNumber(int number)
{
    if (number > 0)
    {
        string outcome = "Positive"; // The lifetime of ‘outcome’ is inside this ‘if’ block
        Console.WriteLine(outcome);
    } // Here the ‘outcome’ is out of scope
}

void PrintNote1(string note = "Welcome")
{
    Console.WriteLine(note);
}

PrintNote1(); // The output is: Welcome
PrintNote1("Hello"); // The output is: Hello

void DisplayPersonalData(string name, int age, string address)
{
    Console.WriteLine($"Name is: {name}, Age is: {age}, Address is: {address}");
}

// Calling the method using named arguments
DisplayPersonalData(address: "123 street", name: "Stacy", age: 45);

void ReportText(string content, string severity = "info", bool toFile = false)
{
    // Implementation code
}

// Combining both default and specified arguments
ReportText("Informative message.");
ReportText("Warning message", severity: "Warning");
ReportText("Error message", severity: "Error", toFile: true);

class Overloading {
    // Display function with a string parameter
    void Display1(string note) { }
    // Display function with an integer parameter
    void Display1(int digit) { }
    // Display function with two parameters
    void Display1(string note, int digit) { }

    // Sum function with integer return type and two integer parameters
    int Sum1(int x, int y) { return x + y; }
    // Sum function with double return type and two double parameters
    double Sum1(double x, double y) { return x + y; }
}




