public class DocumentWriter : IWriter, IFileWriter
{
    void IWriter.Write(string text)
    {
        Console.WriteLine($"Writing text: {text}");
    }

    void IFileWriter.Write(string filePath)
    {
        Console.WriteLine($"Writing to file: {filePath}");
    }
}
