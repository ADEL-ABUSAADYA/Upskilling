namespace ASS2.Vehicle_Control_System;

public class Truck : Vehicle
{
    public float LoadCapacity { get; set; }

    public Truck(string name, float loadCapacity) : base(name)
    {
        LoadCapacity = loadCapacity;
    }

    public override void Start()
    {
        Console.WriteLine($"{Name} (Truck) is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine($"{Name} (Truck) is stopping.");
    }

    public override void Describe()
    {
        Console.WriteLine($"{Name} is a truck with a load capacity of {LoadCapacity} tons.");
    }
}