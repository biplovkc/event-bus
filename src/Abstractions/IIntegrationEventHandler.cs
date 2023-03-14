namespace Biplov.EventBus.Abstractions;

/// <summary>
/// Defines an empty interface for an integration event handler.
/// </summary>
public interface IIntegrationEventHandler
{
}

/// <summary>
/// Defines an interface for an integration event handler that handles a specific type of integration event.
/// </summary>
/// <typeparam name="TIntegrationEvent">The type of integration event to handle.</typeparam>
public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
    where TIntegrationEvent : IntegrationEvent
{
    /// <summary>
    /// Handles the specified integration event.
    /// </summary>
    /// <param name="event">The integration event to handle.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task Handle(TIntegrationEvent @event);
}
