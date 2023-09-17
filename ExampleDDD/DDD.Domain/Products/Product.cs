namespace DDD.Domain.Products;

public class Product
{
    public int Id { get; set; }
    public string Name { get; private set; } = string.Empty;

    public Money Price { get; private set; }
    public Sku Sku { get; private set; }

}
