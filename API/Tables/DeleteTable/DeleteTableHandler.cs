namespace API.Tables.DeleteTable;

public record DeleteTableCommand(Guid TableId) : ICommand<DeleteTableResult>;
public record DeleteTableResult(bool IsSuccess);

public class DeleteTableHandler(ITableRepository repository) : ICommandHandler<DeleteTableCommand, DeleteTableResult>
{
    public async Task<DeleteTableResult> Handle(DeleteTableCommand request, CancellationToken cancellationToken)
    {
        var success = await repository.DeleteTable(request.TableId);
        return new DeleteTableResult(success);
    }
}
