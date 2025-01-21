using MediatR;

namespace CrossCutting.CQRS;

public interface IQuery<out TResponse> : IRequest<TResponse> where TResponse : notnull;