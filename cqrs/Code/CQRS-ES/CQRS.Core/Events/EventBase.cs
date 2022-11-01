using CQRS.Core.Messages;

namespace CQRS.Core.Events;

public abstract class EventBase : Message
{
    protected EventBase(string type)
    {
        Type = type;
    }
    public int Version { get; set; }
    public string Type { get; set; }
}