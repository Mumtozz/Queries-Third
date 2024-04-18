namespace _001GroupBy;

public class OrderItem
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public string ProductName { get; set; } = null!;
    public int OrderId { get; set; }
    public Order? Order { get; set; }
}