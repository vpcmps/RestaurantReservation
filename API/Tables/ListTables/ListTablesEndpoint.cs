namespace API.Tables.ListTables;

public class ListTablesEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/tables", () =>
        {

        })
            .WithName("ListTables")
        //.Produces<GetBasketResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("List tables")
        .WithDescription("List tables");

    }
}
