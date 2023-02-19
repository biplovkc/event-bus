namespace Biplov.EventBus.Events;

public record IntegrationEvent
{
    public IntegrationEvent()
    {
        Id = Guid.NewGuid().ToString("N");
        CreationDate = DateTime.UtcNow;
    }

    public IntegrationEvent(string id, DateTime creationDate)
    {
        if (string.IsNullOrWhiteSpace(id))
        {
            id = Guid.NewGuid().ToString("N");
        }

        Id = id;
        CreationDate = creationDate;
    }
    public string Id { get; private set; }
    public DateTime CreationDate { get; private set; }
}