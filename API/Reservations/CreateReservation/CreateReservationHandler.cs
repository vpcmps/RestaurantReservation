namespace API.Reservations.CreateReservation;

public record CreateResertvationCommand(Guid TableId, Guid UserId) : ICommand<CreateReservationResult>;
public record CreateReservationResult(Guid TableId);

public class CreateReservationHandler(IReservationRepository repository) : ICommandHandler<CreateResertvationCommand, CreateReservationResult>
{
    public async Task<CreateReservationResult> Handle(CreateResertvationCommand command, CancellationToken cancellationToken)
    {
        var reservation = new Reservation()
        {
            Date = DateTime.Now,
            Id = Guid.NewGuid(),
            Status  = EnumReservationStatus.Active,
            TableId = command.TableId,
            UserId = command.UserId,
        };

        var result = await repository.CreateReservation(reservation);
        return new CreateReservationResult(result.Id);
    }
}
