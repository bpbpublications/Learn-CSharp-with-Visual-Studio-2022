public class Library
{
    public string Name { get; set; }
    public void OpenLibrary()
    {
        // Implementation
    }

    private string libraryCode;
    private void GenerateLibraryCode()
    {
        // Implementation
    }

    protected string Location { get; set; }
}

public class PublicLibrary : Library
{
    public void SetLocation(string location)
    {
        Location = location;
    }
}
