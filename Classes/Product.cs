namespace labbG.Classes;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string? ImageUrl { get; set; }
    public int PriceInUsd { get; set; }
    public Product(int id, string name, string description, string? imageUrl, int priceInUsd) =>
        (Id, Name, Description, ImageUrl, PriceInUsd) = (id, name, description, imageUrl, priceInUsd);
}