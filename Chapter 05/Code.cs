Arithmetic calculate = new Arithmetic();
int product = calculate.Multiply(5, 8);
Console.WriteLine($"Product = {product}");

// Object Creation
Bike myBike = new Bike("Altis", "Japan", 2022);

// Accessing Members
myBike.Model = "Altis";
myBike.BikeStart();

Bike mybike = new Bike()
{
    Model = "Altis",
    MadeIn = "Japan",
    ReleaseYear = 2022
};

myBike.BikeStart();

Bike myBike1 = new Bike("Altis", "Japan", 2022)
{
    Model = "Corolla",
    // Additional properties can be set or overridden here
};

myBike1.BikeStart();

