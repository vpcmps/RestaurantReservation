
namespace API.Reservations.UpdateReservation;

public record UpdateReservationCommand(): ICommand<UpdateReservationResult>;
public record UpdateReservationResult();

public class UpdateReservationHandler : ICommandHandler<UpdateReservationCommand, UpdateReservationResult>
{
    public Task<UpdateReservationResult> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
