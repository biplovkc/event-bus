namespace Biplov.EventBus.Abstractions;

public interface IIntegrationEventHandler
{
}

public interface IIntegrationEventHandler<in TDomainEvent> : IIntegrationEventHandler
    where TDomainEvent : IntegrationEvent
{
    Task Handle(TDomainEvent @event);
}