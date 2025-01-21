namespace API.Reservations.GetReservation;

public class ListReservationsEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/reservations", () => { });
    }
}
