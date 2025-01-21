namespace API.Tables.CreateTable;

public class CreateTableEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("/tables", () =>
        {

        }).WithName("CreateTable")
        //.Produces<GetBasketResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Create a new table")
        .WithDescription("Create a new table");
    }
}
