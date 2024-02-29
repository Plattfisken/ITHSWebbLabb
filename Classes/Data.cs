namespace labbG.Classes;
public class Data
{
    public readonly List<Product> products = new List<Product>();
    public int NextId => products.Count == 0 ? 1 : products.Max(p => p.Id + 1);
    public Data() => SeedData();
    void SeedData() {
        products.Add(new Product(NextId, "Phone", "Good phone", "images/phone.jpg", 300));
        products.Add(new Product(NextId, "Macbook", "It's very good", "images/macbook.jpg", 2000));
        products.Add(new Product(NextId, "Apple watch", "Can tell the time and more ;)", "images/watch.jpg", 100));
        products.Add(new Product(NextId, "Headphones", "Audio quality is good", "images/headphones.jpg", 50));
        products.Add(new Product(NextId, "Car", "Fast", "images/car.jpg", 10000));
    }
    public Product? GetProduct(int id) {
        return products.SingleOrDefault(p => p.Id == id);
    }
}