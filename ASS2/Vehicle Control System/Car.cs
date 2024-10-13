namespace ASS2.Vehicle_Control_System;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string name, int numberOfDoors) : base(name)
    {
        NumberOfDoors = numberOfDoors;
    }

    // Implementing the Start method
    public override void Start()
    {
        Console.WriteLine($"{Name} (Car) is starting.");
    }

    // Implementing the Stop method
    public override void Stop()
    {
        Console.WriteLine($"{Name} (Car) is stopping.");
    }

    // Implementing the Describe method
    public override void Describe()
    {
        Console.WriteLine($"{Name} is a car with {NumberOfDoors} doors.");
    }
}