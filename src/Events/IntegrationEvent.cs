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
    [JsonConstructor]
    public IntegrationEvent(string id, DateTime creationDate)
    {
        Id = string.IsNullOrEmpty(id)? $"iev_{Guid.NewGuid():N}" : id;

        CreationDate = creationDate == default ? DateTime.UtcNow : creationDate;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationEvent"/> class
    /// with a generated identifier and the current UTC date.
    /// </summary>
    public IntegrationEvent() : this($"iev_{Guid.NewGuid():N}", DateTime.UtcNow)
    {
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
