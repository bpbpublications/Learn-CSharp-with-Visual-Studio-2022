using System.Reflection.Emit;

void ReadFile()
{
    var content = File.ReadAllText("file.txt");
    Console.WriteLine(content);
}

async Task ReadFileAsync()
{
    var content = await File.ReadAllTextAsync("file.txt");
    Console.WriteLine(content);
}

async Task ProcessDataAsync()
{
    Console.WriteLine("Starting data processing...");

    // Simulate a long-running operation
    await Task.Delay(2000);

    Console.WriteLine("Data processing completed.");
}

async Task MainMethodAsync()
{
    await ProcessDataAsync();
    Console.WriteLine("Main method execution continues.");
}

async Task<int> CalculateTotalAsync(int value1, int value2)
{
    int sum = await AddAsync(value1, value2);
    int square = await SquareAsync(sum);
    return square;
}

async Task<int> AddAsync(int a, int b)
{
    return await Task.Run(() => a + b);
}

async Task<int> SquareAsync(int number)
{
    return await Task.Run(() => number * number);
}

async Task ProcessMultipleTasksAsync()
{
    Task<int> task1 = CalculateAsync(10);
    Task<int> task2 = CalculateAsync(20);

    int[] results = await Task.WhenAll(task1, task2);

    Console.WriteLine($"The results are {results[0]}, {results[1]}");
}

async Task<int> CalculateAsync(int value)
{
    return await Task.Run(() => value * 2);
}

void PerformTask()
{
    Task task = Task.Run(() =>
    {
        Console.WriteLine("Task started...");
        Thread.Sleep(2000); // Simulate a time-consuming operation
        Console.WriteLine("Task completed.");
    });
}

async Task<int> CalculateSquareAsync(int number)
{
    return await Task.Run(() =>
    {
        return number * number;
    });
}

async Task DownloadFileAsync(string url, string destinationPath, CancellationToken cancellationToken)
{
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        using (FileStream fs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            await response.Content.CopyToAsync(fs, cancellationToken);
        }
    }
}

async Task SaveDataAsync(string data)
{
    await Task.Run(() =>
    {
        // Simulate saving data to a database
        Thread.Sleep(2000);
        Console.WriteLine("Data saved successfully.");
    });
}

async Task<int> FetchDataAndProcessAsync()
{
    int result = await Task.Run(() =>
    {
        // Simulate fetching and processing data
        Thread.Sleep(3000);
        return 42; // Example result
    });
    return result;
}

async Task LogMessageAsync(string message)
{
    await Task.Run(() =>
    {
        // Simulate logging a message
        Thread.Sleep(1000);
        Console.WriteLine($"Logged: {message}");
    });
}

async Task<int> DivideAsync(int dividend, int divisor)
{
    try
    {
        return await Task.Run(() =>
        {
            if (divisor == 0)
                throw new DivideByZeroException("Divisor cannot be zero.");
            return dividend / divisor;
        });
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        return -1; // Return an error code
    }
}

async Task PerformOperationAsync()
{
    throw new InvalidOperationException("Something went wrong.");
}

async Task MainMethodAsync1()
{
    try
    {
        await PerformOperationAsync();
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Caught exception: {ex.Message}");
    }
}

async Task UpdateLabelAsync(Label label)
{
    // Simulate a delay
    await Task.Delay(2000);

    // This code runs on the original SynchronizationContext
    label.Text = "Update complete";
}

void CallAsyncMethod()
{
    // Potential deadlock
    var result = GetDataAsync().Result;
}

async Task<string> GetDataAsync()
{
    await Task.Delay(1000);
    return "Data";
}

object _lock = new object();
int _counter;

async Task IncrementCounterAsync()
{
    await Task.Run(() =>
    {
        lock (_lock)
        {
            _counter++;
        }
    });
}

async Task<string> FetchDataAsync(string url, CancellationToken cancellationToken)
{
    using (HttpClient client = new HttpClient())
    {
        HttpResponseMessage response = await client.GetAsync("https://example.com/api/data", cancellationToken);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }
}

async Task RunFetchDataWithCancellationAsync()
{
    var cts = new CancellationTokenSource();
    CancellationToken token = cts.Token;

    Task<string> fetchDataTask = FetchDataAsync("https://example.com/api/data", token);

    // Simulate the user canceling the operation
    cts.CancelAfter(5000); // Cancel after 5 seconds

    try
    {
        string data = await fetchDataTask;
        Console.WriteLine("Data fetched: " + data);
    }
    catch (OperationCanceledException)
    {
        Console.WriteLine("Operation was canceled.");
    }
}

async Task ProcessDataAsync1(CancellationToken cancellationToken)
{
    try
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                // Check for cancellation at each step
                cancellationToken.ThrowIfCancellationRequested();
                Thread.Sleep(100); // Simulate work
                Console.WriteLine($"Processing {i}%");
            }
        }, cancellationToken);
    }
    catch (OperationCanceledException)
    {
        Console.WriteLine("Data processing was canceled.");
    }
}

async Task<string> FetchDataWithTimeoutAsync()
{
    using (var cts = new CancellationTokenSource())
    {
        Task<string> fetchDataTask = FetchDataAsync("https://example.com/api/data", cts.Token);

        Task timeoutTask = Task.Delay(10000); // 10 seconds timeout

        Task completedTask = await Task.WhenAny(fetchDataTask, timeoutTask);

        if (completedTask == timeoutTask)
        {
            cts.Cancel(); // Cancel the fetchDataTask if timeout occurs
            throw new TimeoutException("The operation timed out.");
        }

        return await fetchDataTask; // If fetchDataTask completes first, return its result
    }
}
async Task<string> FetchDataAsync1(string url)
{
    using (HttpClient client = new HttpClient())
    {
        try
        {
            string data = await client.GetStringAsync(url);
            return data;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error fetching data: {ex.Message}");
            throw; // Optionally rethrow to let the caller handle it
        }
    }
}

async Task ProcessDataAsync2()
{
    Task<string> dataTask = FetchDataAsync1("https://example.com/api/data");

    try
    {
        string result = await dataTask;
        Console.WriteLine($"Data: {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Caught exception: {ex.Message}");
    }

    if (dataTask.IsFaulted)
    {
        Exception ex = dataTask.Exception;
        Console.WriteLine($"Task exception: {ex.InnerException?.Message}");
    }
}







