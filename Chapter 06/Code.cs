Animal myDog = new Dog1();
Animal myCat = new Cat();

myDog.MakeSound(); // Outputs: Bark
myCat.MakeSound(); // Outputs: Meow

IShape shape1 = new Circle();
IShape shape2 = new Square();

shape1.Draw(); // Outputs: Drawing a Circle
shape2.Draw(); // Outputs: Drawing a Square

MediaDevice device = new MediaDevice();

if(device is IPlayable)
{
    // Object can be cast to IPlayable
}

IPlayable playable = device as IPlayable;

if (playable != null)
{
    // Successfully cast to IPlayable
    playable.Play();
}

