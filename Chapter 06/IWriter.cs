public interface IWriter
{
    void Write(string text);
}

public interface IFileWriter
{
    void Write(string filePath);
}
