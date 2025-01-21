namespace API.Models;

public class Table
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public EnumTableStatus Status { get; set; }
}
