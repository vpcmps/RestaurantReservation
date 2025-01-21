
namespace API.Reservations.GetReservation;

public record ListReservationsQuery : IQuery<ListReservationsResult>;
public record ListReservationsResult(List<Reservation> Reservations);

public class ListReservationsHandler(IReservationRepository repository) : IQueryHandler<ListReservationsQuery, ListReservationsResult>
{
    public async Task<ListReservationsResult> Handle(ListReservationsQuery request, CancellationToken cancellationToken)
    {
        var req = await repository.GetRepository();
        return new ListReservationsResult(req);
    }
}
