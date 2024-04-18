using _001GroupBy.Data;

await using var dataContext = new DataContext();


Console.WriteLine("Good look  😊😊😊");


//1
//Получить все заказы клиента с id=1, отгруппированные по сумме заказа
//Get all customer orders with id=1, grouped by order amount

 var res = dataContext.Orders
            .Where(o => o.CustomerId == 1)
            .GroupBy(order => order.Id)
            .Select(g => new
            {
                OrderId = g.Key,
                TotalAmount = g.Sum(order => order.OrderItems.Sum(x => x.Price * x.Quantity))
            });

        foreach (var item in res)
        {
            Console.WriteLine($"Order ID: {item.OrderId}, Total Amount: {item.TotalAmount}");
        }
    
//2
//Получите все заказы клиентов с ID = 1, сгруппированные по количеству товаров в заказе:
//Get all customer orders with ID = 1, grouped by the number of goods in the order
 var res2 = dataContext.Orders
            .Where(o => o.CustomerId == 1)
            .Select(order => new
            {
                OrderId = order.Id,
                Count = dataContext.OrderItems.Count(oi => oi.OrderId == order.Id)
            });
        var groupedOrders = res2.GroupBy(order => order.Count);

        foreach (var group in groupedOrders)
        {
            Console.WriteLine($"Number of items: {group.Key}");
            foreach (var order in group)
            {
                Console.WriteLine($"Order ID: {order.OrderId}");
            }
        }

//3
//Получить все заказы клиента с id=2, отгруппированные по данным
//Get all customer orders with id=2, grouped by data

 var res3 =dataContext.Orders
            .Where(o => o.CustomerId == 2) 
            .GroupBy(order => order.OrderDate.Date) 
            .Select(g => new
            {
                Date = g.Key,
                Orders = g.ToList()
            }).AsQueryable();

        foreach (var item in res3)
        {
            Console.WriteLine($"Date: {item.Date.ToShortDateString()}");
            foreach (var order in item.Orders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Order Date: {order.OrderDate.ToShortDateString()}");
            }
        }
