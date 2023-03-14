namespace Biplov.EventBus.Events;

/// <summary>
/// Represents an integration event with an identifier and creation timestamp,
/// which can be serialized and deserialized to/from JSON.
/// </summary>
public record IntegrationEvent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationEvent"/> class
    /// with the specified identifier and creation date.
    /// </summary>
    public IntegrationEvent()
    {
        Id = $"iev_{Guid.NewGuid():N}";

        CreationDate = DateTime.UtcNow;
    }

    /// <summary>
    /// Gets the identifier for the integration event.
    /// </summary>
    public string Id { get; private init; }

    /// <summary>
    /// Gets the creation date for the integration event.
    /// </summary>
    public DateTime CreationDate { get; private init; }
}

