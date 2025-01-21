namespace API.Tables.DeleteTable;

public class DeleteTableEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapDelete("/tables/{id}", () =>
        {

        })
            .WithName("DeleteTable")
        //.Produces<GetBasketResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Delete table")
        .WithDescription("Delete table");
    }
}
