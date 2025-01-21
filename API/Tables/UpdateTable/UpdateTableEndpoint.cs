namespace API.Tables.UpdateTable;

public class UpdateTableEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPatch("/tables/{id}", () =>
        {

        })
            .WithName("UpdateTable")
        //.Produces<GetBasketResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Update table info")
        .WithDescription("Update table info");
    }
}
