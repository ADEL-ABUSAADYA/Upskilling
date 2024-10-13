namespace ASS2.Vehicle_Control_System;

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle(string name, bool hasSidecar) : base(name)
    {
        HasSidecar = hasSidecar;
    }

    public override void Start()
    {
        Console.WriteLine($"{Name} (Motorcycle) is starting.");
    }

    public override void Stop()
    {
        Console.WriteLine($"{Name} (Motorcycle) is stopping.");
    }

    public override void Describe()
    {
        string sidecarInfo = HasSidecar ? "with a sidecar" : "without a sidecar";
        Console.WriteLine($"{Name} is a motorcycle {sidecarInfo}.");
    }
}