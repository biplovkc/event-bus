namespace Biplov.EventBus.Abstractions;

/// <summary>
/// Defines an interface for a dynamic integration event handler that can handle events of any type.
/// </summary>
public interface IDynamicIntegrationEventHandler
{
    /// <summary>
    /// Handles the specified dynamic integration event data.
    /// </summary>
    /// <param name="eventData">The dynamic integration event data to handle.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task Handle(dynamic eventData);
}
