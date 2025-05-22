using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Scripting.Hosting;
using System.Dynamic;
using System.Reflection;

dynamic example = "Hello, Dynamic World!";
Console.WriteLine(example.Length);  // Output: 18
example = 100;
Console.WriteLine(example + 50);  // Output: 150

var staticVariable = "Hello, World!";  // Type inferred as string at compile-time
dynamic dynamicVariable = "Hello, Dynamic World!";  // Type resolved at runtime

dynamic obj = "Sample String";
Console.WriteLine(obj.ToUpper());  // This works fine
obj = 42;
// Console.WriteLine(obj.ToUpper());  // Runtime error: 'int' does not contain a definition for 'ToUpper'

dynamic person = new ExpandoObject();
person.Name = "John";
person.Age = 30;

Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Age: {person.Age}");

// Adding a method
person.SayHello = new Action(() => Console.WriteLine("Hello!"));
person.SayHello();

dynamic car = new ExpandoObject();
car.Make = "Toyota";
car.Model = "Camry";
Console.WriteLine($" Make: {car.Make}, Model: {car.Model} ");

// Adding a new property
((IDictionary<string, object>)car)["Year"] = 2021;
Console.WriteLine($"Year: {car.Year}");

// Removing a property
((IDictionary<string, object>)car).Remove("Model");

dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
excel.Visible = true;

dynamic workbook = excel.Workbooks.Add();
dynamic worksheet = workbook.Worksheets[1];
worksheet.Cells[1, 1].Value = "Hello, COM!";

workbook.Close(false);  // false = don't save changes
excel.Quit();

object obj1 = "Hello, World!";
string message = (string)obj1;  // Explicit casting required
Console.WriteLine(message);

dynamic obj2 = "Hello, World!";
Console.WriteLine(obj2.Length);  // Accessing Length without explicit casting

dynamic value = 42;
// Console.WriteLine((string)value);  // Runtime error: Invalid cast from 'int' to 'string'

dynamic data = 123;
if (data is int)
{
    Console.WriteLine("Data is an integer.");
}

dynamic obj3 = new { Name = "Alice", Age = 25 };

Type type3 = obj3.GetType();
PropertyInfo nameProperty = type3.GetProperty("Name");
Console.WriteLine($" The Name is {nameProperty.GetValue(obj3)} ");

dynamic obj4 = new ExpandoObject();
obj4.Greet = new Action(() => Console.WriteLine("Hello, World!"));

// Use dictionary to retrieve the delegate
var dict = obj4 as IDictionary<string, object>;
if (dict.TryGetValue("Greet", out object greetObj) && greetObj is Delegate greetDelegate)
{
    greetDelegate.DynamicInvoke();
}


dynamic obj5 = new ExpandoObject();
obj5.Name = "Bob";
obj5.Age = 30;

Type type5 = obj5.GetType();
foreach (var property in type5.GetProperties())
{
    Console.WriteLine($" {property.Name}: {property.GetValue(obj)} ");
}

dynamic dynamicObject = new ExpandoObject();
dynamicObject.Greet = new Action(() => Console.WriteLine("Hello from DLR!"));

dynamicObject.Greet();  // DLR resolves the method call at runtime

ScriptEngine engine = Python.CreateEngine();
ScriptScope scope = engine.CreateScope();

engine.Execute(@"
def greet():
    return 'Hello from Python!'
", scope);

// Retrieve the greet function from the scope
dynamic greetFunc = scope.GetVariable("greet");

// Call the Python function
string result = greetFunc();
Console.WriteLine(result);

dynamic Value = "string";
// Console.WriteLine(Value + 5); // Error: String and Int cannot be added

dynamic obj6 = new ExpandoObject();
// obj6.ExistingMethod();  // Runtime error: Method does not exist

dynamic obj7 = "Hello";
try
{
    Console.WriteLine(obj7.Length);  // Valid for string
    Console.WriteLine(obj7.ToUpper());  // Runtime error if obj is not a string
}
catch (RuntimeBinderException ex)
{
    Console.WriteLine("Runtime error: " + ex.Message);
}

dynamic obj8 = 42;
if (obj8 is string)
{
    Console.WriteLine(((string)obj8).ToUpper());
}
else
{
    Console.WriteLine("Object is not a string.");
}

var data1 = new List<string> { "apple", "banana", "cherry", "date" };
string searchTerm = "a";

var query = data1.Where(item => item.Contains(searchTerm));
foreach (var item in query)
{
    Console.WriteLine(item);
}

dynamic data2 = new ExpandoObject();
data2.Items = new List<int> { 1, 2, 3, 4, 5 };

var result2 = ((IEnumerable<int>)data2.Items).Where(x => x > 2).ToList();
foreach (var item in result)
{
    Console.WriteLine(item);
}

dynamic data3 = new ExpandoObject();
data3.Items = new List<string> { "apple", "banana", "apricot", "orange" };

string filterTerm = "ap";
var items = (IEnumerable<string>)data3.Items;

var query3 = items.AsQueryable();
if (!string.IsNullOrEmpty(filterTerm))
{
    query3 = query3.Where(item => item.Contains(filterTerm));
}

var results = query3.ToList();
foreach (var item in results)
{
    Console.WriteLine(item);
}

