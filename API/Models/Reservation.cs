namespace API.Models;

public class Reservation
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid TableId { get; set; }
    public Table Table { get; set; }
    public DateTime Date { get; set; }
    public EnumReservationStatus Status { get; set; }
}
