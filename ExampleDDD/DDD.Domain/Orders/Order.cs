using DDD.Domain.Customers;
using DDD.Domain.Products;
using System.Reflection.Metadata.Ecma335;

namespace DDD.Domain.Orders;

public class Order
{
    private readonly HashSet<LineItem> _lineItems = new();

    public Order()
    {

    }
    public int Id { get; private set; }
    public int CustomerId { get; private set; }

    public static Order Create(Customer customer)
    {
        var order = new Order
        {
            CustomerId = customer.Id
        };

        return order;
    }

    public void Add(Product product)
    {
        var lineItem = new LineItem(Id, product.Id, product.Price);

        _lineItems.Add(lineItem);
    }
}

public class LineItem
{
    public LineItem(int orderId, int productId, Money price)
    {
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }
    public int Id { get; private set; }
    public int OrderId { get; private set; }
    public int ProductId { get; private set; }
    public Money Price { get; private set; }

}