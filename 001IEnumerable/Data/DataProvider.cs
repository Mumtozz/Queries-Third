namespace Data;
using _001GroupBy;
public class DataProvider
{
    public static List<OrderItem> OrderItem { get; private set; } = new()     {
         new OrderItem()
    {
        Id=1,
        Price = 2300,
        Quantity = 4,
        OrderId = 1,
        ProductName = "Rc"
    },
    new OrderItem()
    {
        Id=2,
        OrderId = 2,
        Quantity = 5,
        Price = 1250,
        ProductName = "Banana"
    },
    new OrderItem()
    {
        Id=3,
        OrderId = 3,
        Quantity = 6,
        Price = 2340,
        ProductName = "Water"
    },
       new OrderItem()
       {
        Id=4,
        OrderId = 1,
        Price = 540,
        Quantity = 7,
        ProductName = "Chocolate"
       }
   };

    public static List<Order> Order { get; private set; } = new() {
        new Order()
    {
        Id=1,
        CustomerId = 1,
        OrderDate = DateTime.UtcNow.Date,
    },
    new Order()
    {
        Id=2,
        OrderDate = DateTime.UtcNow.Date,
        CustomerId = 2,
    },
    new Order()
    {
        Id=3,
        CustomerId = 1,
        OrderDate = DateTime.UtcNow.Date,
    }    };



   public static List<Customer> Customer { get; private set; } = new() {
     new Customer()
    {
        Id=1,
        Name = "Akmal",
    },
    new Customer()
    {
        Id=2,
        Name = "Ahmad",
    } };

}