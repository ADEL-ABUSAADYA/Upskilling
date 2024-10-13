namespace DAY_ONE;

public class Product
{
    public string Name { get; set; }
    private decimal price;
    private int stockQuantity;
    
    public bool IsAvailable
    {
        get { return StockQuantity > 0; }
    }
    public decimal Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Price cannot be negative.");
            }
            price = value;
        }
    }
    public int StockQuantity
    {
        get { return stockQuantity; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Stock quantity cannot be negative.");
            }
            stockQuantity = value;
        }
    }
    
   
    public void UpdateStock(int quantity)
    {
        if (quantity < 0 && quantity > StockQuantity)
        {
            Console.WriteLine("Insufficient stock to remove.");
        }
        StockQuantity += quantity;
    }
}