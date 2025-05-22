int[] digits = new int[4];
digits[0] = 2;
digits[1] = 4;
digits[2] = 6;
digits[3] = 8;

int firstdigit = digits[0]; // accessing the first element of the array
int seconddigit = digits[1]; // accessing the second element of the array
digits[0] = 2; // modifying the first element of the array
digits[1] = 4; // modifying the second element of the array

List<int> digits1 = new List<int>();
digits1.Add(2);
digits1.Add(4);
digits1.Add(6);
digits1.Add(8);

bool hasNumber = digits1.Contains(8);
int index = digits1.IndexOf(8);
digits1.Insert(0, 12);
digits1.Sort();
digits1.Reverse();
int count = digits1.Count;
int capacity = digits1.Capacity;

Dictionary<int, string> employees = new Dictionary<int, string>();
employees.Add(1, "Cynthia");
employees.Add(2, "John");
employees.Add(3, "Alice");
employees.Add(4, "Michael");

employees.Add(4, "Shabnam");
employees[5] = "Emily";
employees.Remove(4);
employees.Clear();
string employeeName = employees[1];

foreach (KeyValuePair<int, string> employee in employees)
{
    Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
}

bool hasKey = employees.ContainsKey(1);
bool hasValue = employees.ContainsValue("Emily");

if (employees.TryGetValue(1, out string name))
{
    Console.WriteLine(name);
}

ICollection<int> keys = employees.Keys;
ICollection<string> values = employees.Values;
count = employees.Count;

Queue<string> buffers = new Queue<string>();
buffers.Enqueue("Buffer 1");
buffers.Enqueue("Buffer 2");
buffers.Enqueue("Buffer 3");
buffers.Enqueue("Buffer 4");

string buffer = buffers.Dequeue();
buffer = buffers.Dequeue();
count = buffers.Count;

foreach (string buffer1 in buffers)
{
    Console.WriteLine(buffer1);
}

Stack<string> history = new Stack<string>();
history.Push("Page 1");
history.Push("Page 2");
history.Push("Page 3");
history.Push("Page 4");

string lastPage = history.Pop();
string currentPage = history.Peek(); // "Page 1"
count = history.Count;
foreach (string page in history)
{
    Console.WriteLine(page);
}


foreach (int digit in digits)
{
    Console.WriteLine(digit);
}

int[,] table = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

int item = table[0, 0];

table[0, 0] = 10;

// Iterating through the array using nested loops.
for (int a = 0; a < table.GetLength(0); a++) // The outer loop iterates over rows.
{
    for (int b = 0; b < table.GetLength(1); b++) // The inner loop iterates over columns.
    {
        Console.WriteLine(table[a, b]); // Prints the element at row 'a' and column 'b'.
    }
}

NonGenericClass instance = new NonGenericClass();
instance.Display<int>(10); // Output: Value: 10

instance.Display<string>("Hello"); // Output: Value: Hello

Container<int> intContainer = new Container<int>(42);
intContainer.Display(); // Output: Value: 42

Container<string> stringContainer = new Container<string>("Hello, World!");
stringContainer.Display(); // Output: Value: Hello, World!

Pair<int, string> pair = new Pair<int, string>(1, "One");
pair.Display(); // Output: First: 1, Second: One

List<string> names = new List<string> { "Michael", "Thomas", "John" };
names.Add("Alice");
names.Remove("Michael ");

foreach (string name1 in names)
{
    Console.WriteLine(name1);
}


int[] Digits = { 2, 4, 6, 8, 10 };
var evenDigits = from num in Digits
                 where num % 2 == 0
                 select num;

foreach (var num in evenDigits)
{
    Console.WriteLine(num); // This will display 2, 4, 6, 8, and 10, as all of them are even
}

digits = new int[] { 6, 7, 8, 9, 10 };
evenDigits = digits.Where(num => num % 2 == 0);

foreach (var num in evenDigits)
{
    Console.WriteLine(num); // This will display 6, 8, and 10
}

List<string> persons = new List<string> { "John", "William", "Joseph", "Charles" };
var filteredPersons = persons.Where(person => person.StartsWith("J"));

foreach (var person in filteredPersons)
{
    Console.WriteLine(person); // This will output 'John' and 'Joseph'
}

employees = new Dictionary<int, string>
{
    { 1, "Alice" },
    { 2, "Bob" },
    { 3, "Charlie" },
    { 4, "David" }
};
var filteredEmployees = employees.Where(employee => employee.Key % 2 == 0);

foreach (var employee in filteredEmployees)
{
    Console.WriteLine($"{employee.Key}: {employee.Value}"); // Output: 2: Bob, 4: David
}

var numbers = Enumerable.Range(0, 20);
var evenNumbers = numbers.Where(num => num % 2 == 0);

var squares = numbers.Select(num => num * num);
var sortedNames = names.OrderBy(name => name);
var sortedNamesDesc = names.OrderByDescending(name => name);
count = numbers.Count();

int sum = numbers.Sum();
double average = numbers.Average();
int max = numbers.Max();
int min = numbers.Min();

var groupedNames = names.GroupBy(name => name.Length);

foreach (var group in groupedNames)
{
    Console.WriteLine($"Length: {group.Key}");
    foreach (var name1 in group)
    {
        Console.WriteLine(name1);
    }
}

var people = new List<Person>
{
    new Person { Id = 1, Name = "Alice" },
    new Person { Id = 2, Name = "Bob" }
};
var orders = new List<Order>
{
    new Order { PersonId = 1, Product = "Book" },
    new Order { PersonId = 2, Product = "Pen" }
};
var personOrders = people.Join(orders,
                               person => person.Id,
                               order => order.PersonId,
                               (person, order) => new { person.Name, order.Product });

foreach (var po in personOrders)
{
    Console.WriteLine($"{po.Name} ordered {po.Product}");
}
