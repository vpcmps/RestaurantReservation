using API.Exceptions;

namespace API.Tables.UpdateTable;

public record UpdateTableCommand(Guid IdTable, Table Table) : ICommand<UpdateTableResult>;
public record UpdateTableResult(bool IsSuccess);

public class UpdateTableHandler(ITableRepository repository) : ICommandHandler<UpdateTableCommand, UpdateTableResult>
{
    public async Task<UpdateTableResult> Handle(UpdateTableCommand request, CancellationToken cancellationToken)
    {
        var table = await repository.GetTableById(request.IdTable);

        if(table is null)
        {
            throw new TableNotFoundException();
        }

        table.Name = request.Table.Name;
        table.Status = request.Table.Status;
        table.Capacity = request.Table.Capacity;

        var result = await repository.UpdateTable(table);

        return new UpdateTableResult(result);
    }
}
