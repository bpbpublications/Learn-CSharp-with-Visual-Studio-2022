// Using File class
using System.Net.Sockets;

var fileStream = File.Create("example.txt");
fileStream.Close();
// Using FileInfo class
var fileInfo = new FileInfo("example1.txt");
var fileStream2 = fileInfo.Create();
fileStream2.Close();

// Using File class
string content = File.ReadAllText("example.txt");
// Using FileStream
using (var streamReader = new StreamReader("example.txt"))
{
    string content2 = streamReader.ReadToEnd();
}

// Using File class
File.WriteAllText("example.txt", "Hello, World!");
// Using FileStream
using (var streamWriter = new StreamWriter("example.txt"))
{
    streamWriter.Write("Hello, World!");
}

// Using File class
File.Delete("example.txt");
// Using FileInfo class
fileInfo = new FileInfo("example.txt");
fileInfo.Delete();

fileInfo = new FileInfo("example.txt");
fileInfo.Create().Close();
Console.WriteLine(fileInfo.Length);
fileInfo.Delete();

var directoryInfo = new DirectoryInfo("exampleDirectory");
directoryInfo.Create();
Console.WriteLine(directoryInfo.FullName);
directoryInfo.Delete(true);

using (StreamReader reader = new StreamReader("example2.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

using (FileStream fs = new FileStream("example.bin", FileMode.Open, FileAccess.Read))
{
    byte[] buffer = new byte[fs.Length];
    int bytesRead = fs.Read(buffer, 0, buffer.Length);

    Console.WriteLine("Bytes read: " + bytesRead);
    // Process the binary data as needed
}

content = File.ReadAllText("example2.txt");
Console.WriteLine(content);

string[] lines = File.ReadAllLines("example2.txt");
foreach (string line in lines)
{
    Console.WriteLine(line);
}

using (StreamWriter writer = new StreamWriter("example3.txt"))
{
    writer.WriteLine("Hello, World!");
    writer.WriteLine("Writing to a text file using StreamWriter");
}

byte[] data = { 0x0, 0x1, 0x2, 0x3, 0x4 };
using (FileStream fs = new FileStream("example2.bin", FileMode.Create, FileAccess.Write))
{
    fs.Write(data, 0, data.Length);
}

content = "Hello, World!\nWriting to a file using File.WriteAllText";
File.WriteAllText("example4.txt", content);

string[] lines1 = { "Hello, World!", "Writing to a file using File.WriteAllLines" };
File.WriteAllLines("example5.txt", lines1);

// Using Directory class
Directory.CreateDirectory("exampleDirectory");

// Using DirectoryInfo class
DirectoryInfo dirInfo = new DirectoryInfo("exampleDirectoryInfo");
dirInfo.Create();

// Using Directory class
Directory.Delete("exampleDirectory", true);

// Using DirectoryInfo class
DirectoryInfo dirInfo1 = new DirectoryInfo("exampleDirectoryInfo");
dirInfo1.Delete(true);

// Using DirectoryInfo class
DirectoryInfo dirInfo2 = new DirectoryInfo("exampleDirectory");
dirInfo2.Create();
string[] files = Directory.GetFiles("exampleDirectory");
foreach (string file in files)
{
    Console.WriteLine(file);
}

string[] directories = Directory.GetDirectories("exampleDirectory");
foreach (string directory in directories)
{
    Console.WriteLine(directory);
}

using (FileStream fs = new FileStream("example2.txt", FileMode.OpenOrCreate))
{
    byte[] data1 = new byte[fs.Length];
    fs.Read(data1, 0, data1.Length);
    Console.WriteLine(System.Text.Encoding.UTF8.GetString(data1));
}

using (MemoryStream ms = new MemoryStream())
{
    byte[] data2 = System.Text.Encoding.UTF8.GetBytes("Hello, MemoryStream!");
    ms.Write(data2, 0, data2.Length);

    // Reset the position to the beginning of the stream
    ms.Position = 0;

    byte[] buffer = new byte[ms.Length];
    ms.Read(buffer, 0, buffer.Length);
    Console.WriteLine(System.Text.Encoding.UTF8.GetString(buffer));
}

TcpClient client = new TcpClient("example.com", 80);
using (NetworkStream ns = client.GetStream())
{
    byte[] request = System.Text.Encoding.ASCII.GetBytes("GET / HTTP/1.1\r\nHost: example.com\r\n\r\n");
    ns.Write(request, 0, request.Length);

    byte[] response = new byte[1024];
    int bytesRead = ns.Read(response, 0, response.Length);
    Console.WriteLine(System.Text.Encoding.ASCII.GetString(response, 0, bytesRead));
}

using (StreamReader reader = new StreamReader("example2.txt"))
{
    string content1 = reader.ReadToEnd();
    Console.WriteLine(content1);
}

using (StreamWriter writer = new StreamWriter("example6.txt"))
{
    writer.WriteLine("Hello, StreamWriter!");
}

string filePath = "example7.txt";
byte[] dataToWrite = new byte[10000]; // Example data
new Random().NextBytes(dataToWrite); // Fill with random bytes

// Writing with BufferedStream
using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
using (BufferedStream bs = new BufferedStream(fs))
{
    bs.Write(dataToWrite, 0, dataToWrite.Length);
    Console.WriteLine("Data written with BufferedStream.");
}

// Reading with BufferedStream
byte[] dataRead = new byte[10000];
using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
using (BufferedStream bs = new BufferedStream(fs))
{
    int bytesRead = bs.Read(dataRead, 0, dataRead.Length);
    Console.WriteLine($"Data read with BufferedStream: {bytesRead} bytes.");
}

