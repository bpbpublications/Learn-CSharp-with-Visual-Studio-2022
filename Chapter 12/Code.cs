using System.Reflection;

[Obsolete("Use NewMethod instead")]
void OldMethod()
{
    // Old implementation
}

Assembly assembly = Assembly.Load("mscorlib");
Type[] types = assembly.GetTypes();

foreach (Type type1 in types)
{
    Console.WriteLine(type1.FullName);
}

// Load assembly from file
// Assembly assembly = Assembly.LoadFrom("SomeAssembly.dll");
// Console.WriteLine($"Loaded Assembly: {assembly.FullName}");

// Load assembly by name
Assembly anotherAssembly = Assembly.Load("mscorlib");
Console.WriteLine($" Loaded Assembly: {anotherAssembly.FullName} ");

// Load an assembly
assembly = anotherAssembly;

// Get all types in the assembly
types = assembly.GetTypes();

foreach (Type type1 in types)
{
    Console.WriteLine($"Type: {type1.FullName}");

    // Get all methods in the type
    MethodInfo[] methods = type1.GetMethods();
    foreach (var method1 in methods)
    {
        Console.WriteLine($" - Method: {method1.Name}");
    }

    // Get all properties in the type
    PropertyInfo[] properties = type1.GetProperties();
    foreach (var property1 in properties)
    {
        Console.WriteLine($" - Property: {property1.Name}");
    }

    // Get all fields in the type
    FieldInfo[] fields = type1.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
    foreach (var field in fields)
    {
        Console.WriteLine($" - Field: {field.Name}");
    }

    // Get all events in the type
    EventInfo[] events = type1.GetEvents();
    foreach (var ev in events)
    {
        Console.WriteLine($" - Event: {ev.Name}");
    }
}

// Retrieve custom attributes for a class
Type type = typeof(SampleClass);
object[] classAttributes = type.GetCustomAttributes(typeof(DeveloperInfoAttribute), false);
foreach (DeveloperInfoAttribute attr in classAttributes)
{
    Console.WriteLine($"Class Developer: {attr.Name}, Date: {attr.Date}");
}

// Retrieve custom attributes for a method
MethodInfo method = type.GetMethod("SampleMethod");
object[] methodAttributes = method.GetCustomAttributes(typeof(DeveloperInfoAttribute), false);
foreach (DeveloperInfoAttribute attr in methodAttributes)
{
    Console.WriteLine($"Method Developer: {attr.Name}, Date: {attr.Date}");
}

// Retrieve custom attributes for a property
PropertyInfo property = type.GetProperty("SampleProperty");
object[] propertyAttributes = property.GetCustomAttributes(typeof(DeveloperInfoAttribute), false);
foreach (DeveloperInfoAttribute attr in propertyAttributes)
{
    Console.WriteLine($" Property Developer: {attr.Name}, Date: {attr.Date} ");
}

