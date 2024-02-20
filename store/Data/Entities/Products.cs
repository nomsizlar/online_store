namespace store.Data.Entities;

public class Products: BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public Category Category { get; set; } = new(); 
    public int SubCategoryId { get; set; }
}
