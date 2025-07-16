public class OrderService
{
    private readonly List<Order> _orders = new();

    public List<Order> GetActiveOrders()
    {
        return _orders.Where(o => o.IsActive).ToList(); // 🎯 Cible d'optimisation
    }
}

public class Order { public bool IsActive { get; set; } }
