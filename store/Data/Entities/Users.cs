namespace store.Data.Entities;

public class Users : BaseEntity
{
    public string FIO { get; set; }
    public string TelNomer { get; set; }
    public string Password { get; set; }
    public string Adress { get; set; }
    public List<Orders> Orders { get; set; } = new();
}
