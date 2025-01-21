namespace API.Tables.ListTables;

public record ListTablesQuery() : IQuery<ListTablesResult>;
public record ListTablesResult(List<Table> Tables);

public class ListTablesHandler(ITableRepository repository) : IQueryHandler<ListTablesQuery, ListTablesResult>
{
    public async Task<ListTablesResult> Handle(ListTablesQuery request, CancellationToken cancellationToken)
    {
        var result = await repository.ListTables();
        return new ListTablesResult(result);
    }
}
