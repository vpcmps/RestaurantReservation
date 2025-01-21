﻿using MediatR;

namespace CrossCutting.CQRS;

public interface ICommand : IRequest<Unit>;
public interface ICommand<out TResponse> : IRequest<TResponse>;