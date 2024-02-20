namespace store.Data.Entities;

public class OrderItems: BaseEntity
{
    public int ProductId { get; set; }
    public double Amount { get; set; }
    public double TotalPrice { get; set; }

}
