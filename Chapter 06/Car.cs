public class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; private set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}
