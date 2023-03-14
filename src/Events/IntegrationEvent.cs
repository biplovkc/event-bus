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
    /// <param name="id">The identifier for the integration event. If null or whitespace, a new identifier will be generated.</param>
    /// <param name="createdDate">The creation date for the integration event. If default(DateTime), the current UTC date and time will be used.</param>
    public IntegrationEvent(string id = null, DateTime createdDate = default)
    {
        Id = string.IsNullOrWhiteSpace(id) ? $"iev_{Guid.NewGuid():N}" : id;

        CreationDate = createdDate == default ? DateTime.UtcNow : createdDate;
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

