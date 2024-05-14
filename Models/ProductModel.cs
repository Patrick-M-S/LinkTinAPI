public class ProductModel
{
    public long Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public ProductModel(long id
                        , string name
                        , double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

