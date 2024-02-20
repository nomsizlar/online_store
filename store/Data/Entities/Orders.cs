namespace store.Data.Entities;

public class Orders: BaseEntity
{
    public int UserId { get; set; }
    public int Count { get; set; }
    public DateTime Date { get; set; }
    public Users User { get; set; }
    public Products Product { get; set; }
}
