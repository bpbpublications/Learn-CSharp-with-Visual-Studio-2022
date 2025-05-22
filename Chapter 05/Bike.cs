public class Bike
{
    // Fields
    public string Model { get; set; }
    public string MadeIn { get; set; }
    public int ReleaseYear { get; set; }

    // Methods
    public void BikeStart()
    {
        // Implementation
    }

    public void BikeStop()
    {
        // Implementation
    }

    // Constructor
    public Bike()
    { }

    public Bike(string model, string madeIn, int releaseYear)
    {
        Model = model;
        MadeIn = madeIn;
        ReleaseYear = releaseYear;
    }
}
