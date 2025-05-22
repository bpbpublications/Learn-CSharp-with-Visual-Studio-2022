string userInput = "2";

try
{
    // Code that may throw an exception
    int result = 10 / int.Parse(userInput);
}
catch (FormatException)
{
    // Handle format exception
    Console.WriteLine("Input is not a valid number.");
}
catch (DivideByZeroException)
{
    // Handle divide by zero exception
    Console.WriteLine("Cannot divide by zero.");
}

try
{
    // Code that may throw multiple exceptions
    string[] numbers = { "10", "30", "NaN", "40" };
    foreach (var number in numbers)
    {
        int result = 10 / int.Parse(number);
        Console.WriteLine(result);
    }
}
catch (FormatException ex)
{
    // Handle format exception
    Console.WriteLine("A number format issue occurred: " + ex.Message);
}
catch (DivideByZeroException ex)
{
    // Handle divide by zero exception
    Console.WriteLine("Attempted to divide by zero: " + ex.Message);
}
catch (Exception ex)
{
    // Handle any other exceptions
    Console.WriteLine("Unexpected error has occurred: " + ex.Message);
}

FileStream file = null;
try
{
    // Code that may throw an exception
    file = File.Open("data.txt", FileMode.Open);
    // Operations on the file
}
catch (IOException ex)
{
    // Handle I/O exception
    Console.WriteLine("An I/O error occurred: " + ex.Message);
}
finally
{
    // Code to clean up resources
    if (file != null)
        file.Close();

    Console.WriteLine("File closed.");
}

try
{
    BankAccount account = new BankAccount(100);
    account.Withdraw(150);
}
catch (InsufficientFundsException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
    Console.WriteLine($"Balance: {ex.Balance}, Attempted Withdrawal: {ex.Amount}");
}

try
{
    try
    {
        // Code that might throw an exception
        int result = 10 / int.Parse(userInput);
    }
    catch (FormatException ex)
    {
        // Handle format exceptions specifically
        Console.WriteLine("Input is not a valid number.");
        throw; // Optionally rethrow to be handled by the outer block
    }
}
catch (DivideByZeroException ex)
{
    // Handle divide by zero exception
    Console.WriteLine("Cannot divide by zero.");
}
catch (Exception ex)
{
    // Handle any other exceptions
    Console.WriteLine("Unexpected error has occurred: " + ex.Message);
}

try
{
    // Code that might throw an exception
    int result = 10 / int.Parse(userInput);
}
catch (Exception ex)
{
    // Log the error message
    Console.WriteLine("Error: " + ex.Message);
}

try
{
    // Code that might throw an exception
    int result = 10 / int.Parse(userInput);
}
catch (Exception ex)
{
    // Log the stack trace
    Console.WriteLine("Stack Trace: " + ex.StackTrace);
}

try
{
    try
    {
        // Code that might throw an inner exception
        int result = 10 / int.Parse(userInput);
    }
    catch (FormatException ex)
    {
        // Wrap the inner exception in a new exception
        throw new ApplicationException("An error occurred in the application.", ex);
    }
}
catch (ApplicationException ex)
{
    // Log the inner exception
    Console.WriteLine("Inner Exception: " + ex.InnerException?.Message);
}

try
{
    // Code that might throw specific exceptions
    int result = 10 / int.Parse(userInput);
}
catch (FormatException ex)
{
    // Handle format exceptions specifically
    Console.WriteLine("Input is not a valid number.");
}
catch (DivideByZeroException ex)
{
    // Handle divide by zero exception
    Console.WriteLine("Cannot divide by zero.");
}
catch (Exception ex)
{
    // Handle any other exceptions
    Console.WriteLine("Unexpected error has occurred: " + ex.Message);
}

try
{
    // Code that might throw an exception
}
catch (Exception ex) when (ex is FormatException || ex is DivideByZeroException)
{
    // Handle specific exceptions with a filter
    Console.WriteLine("A specific error occurred: " + ex.Message);
}

if (File.Exists("data.txt"))
{
    // Code to open and process the file
}
else
{
    Console.WriteLine("File not found");
}



