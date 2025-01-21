namespace API.Reservations.UpdateReservation;

public class UpdateReservationEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPatch("/reservations/{id}/cancel", () => { });
    }
}
