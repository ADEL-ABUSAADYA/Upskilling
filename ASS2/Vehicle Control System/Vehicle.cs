namespace ASS2.Vehicle_Control_System;

public abstract class Vehicle
{
    public string Name { get; set; }

    public Vehicle(string name)
    {
        Name = name;
    }

    // Abstract methods to be implemented by each vehicle type
    public abstract void Start();
    public abstract void Stop();
    public abstract void Describe();
}