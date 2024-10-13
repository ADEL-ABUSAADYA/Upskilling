namespace DAY_ONE;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; private set; }
    public int Age
    {
        get { return DateTime.Now.Year - Year; }
    }
    
    public void Drive(int distance)
    {
        if (distance > 0)
        {
            Mileage += distance;
        }
        else
        {
            Console.WriteLine("Distance must be positive.");
        }
    }
    
}