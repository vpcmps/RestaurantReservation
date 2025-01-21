
namespace API.Data;

public interface IReservationRepository
{
    Task<Reservation> CreateReservation(Reservation reservation);
}
