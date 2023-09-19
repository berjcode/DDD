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
    public OrderId Id { get; private set; }
    public CustomerId CustomerId { get; private set; }

    public static Order Create(CustomerId customerId)
    {
        var order = new Order
        {
            CustomerId = customerId
        };

        return order;
    }

    public void Add(ProductId productId, Money price)
    {
        var lineItem = new LineItem(Id, productId, price);

        _lineItems.Add(lineItem);
    }
}

public class LineItem
{
    public LineItem(OrderId orderId, ProductId productId, Money price)
    {
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }
    public LineItemId Id { get; private set; }
    public OrderId OrderId { get; private set; }
    public ProductId ProductId { get; private set; }
    public Money Price { get; private set; }

}
