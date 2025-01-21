using Carter;

namespace API.Reservation.CreateReservation;

public class CreateReservationEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/reservations", () => { });
    }
}
