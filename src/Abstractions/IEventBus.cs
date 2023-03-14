namespace Biplov.EventBus.Abstractions;

/// <summary>
/// Provides methods for publishing and subscribing to integration events.
/// </summary>
public interface IEventBus
{
    /// <summary>
    /// Publishes the specified integration event to all subscribed handlers.
    /// </summary>
    /// <param name="event">The integration event to publish. <see cref="IntegrationEvent"/></param>
    void Publish(IntegrationEvent @event);

    /// <summary>
    /// Publishes the specified collection of integration events to all subscribed handlers.
    /// </summary>
    /// <param name="events">The collection of integration events to publish. <see cref="IntegrationEvent"/></param>
    void Publish(IEnumerable<IntegrationEvent> @events);

    /// <summary>
    /// Subscribes a handler for the specified integration event type.
    /// </summary>
    /// <typeparam name="T">The type of integration event to handle. <see cref="IntegrationEvent"/></typeparam>
    /// <typeparam name="TH">The type of integration event handler. <see cref="IIntegrationEventHandler"/></typeparam>
    void Subscribe<T, TH>()
        where T : IntegrationEvent
        where TH : IIntegrationEventHandler<T>;

    /// <summary>
    /// Subscribes a dynamic handler for the specified event name.
    /// </summary>
    /// <typeparam name="TH">The type of dynamic integration event handler.</typeparam>
    /// <param name="eventName">The name of the event to handle dynamically. <see cref="IDynamicIntegrationEventHandler"/></param>
    void SubscribeDynamic<TH>(string eventName)
        where TH : IDynamicIntegrationEventHandler;

    /// <summary>
    /// Unsubscribes the dynamic handler for the specified event name.
    /// </summary>
    /// <typeparam name="TH">The type of dynamic integration event handler to unsubscribe.</typeparam>
    /// <param name="eventName">The name of the event to unsubscribe from.</param>
    void UnsubscribeDynamic<TH>(string eventName)
        where TH : IDynamicIntegrationEventHandler;

    /// <summary>
    /// Unsubscribes a handler for the specified integration event type.
    /// </summary>
    /// <typeparam name="T">The type of integration event to unsubscribe from. <see cref="IntegrationEvent"/></typeparam>
    /// <typeparam name="TH">The type of integration event handler to unsubscribe. <see cref="IIntegrationEventHandler"/></typeparam>
    void Unsubscribe<T, TH>()
        where TH : IIntegrationEventHandler<T>
        where T : IntegrationEvent;
}
