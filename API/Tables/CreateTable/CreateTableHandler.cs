namespace API.Tables.CreateTable;

public record CreateTableCommand(string Name, int Capacity, EnumTableStatus Status) : ICommand<CreateTableResult>;
public record CreateTableResult(Guid id);

public class CreateTableHandler(ITableRepository repository) : ICommandHandler<CreateTableCommand, CreateTableResult>
{
    public async Task<CreateTableResult> Handle(CreateTableCommand request, CancellationToken cancellationToken)
    {
        var table = new Table()
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Capacity = request.Capacity,
            Status = request.Status,
        };

        var result = await repository.AddTable(table);

        return new CreateTableResult(result.Id);
    }
}
