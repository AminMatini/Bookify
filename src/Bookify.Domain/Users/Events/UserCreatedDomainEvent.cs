﻿namespace Bookify.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid id) : IDomainEvent;
