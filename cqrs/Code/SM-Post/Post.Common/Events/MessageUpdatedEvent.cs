using CQRS.Core.Events;

namespace Post.Common.Events;

public class MessageUpdatedEvent : EventBase
{
    public MessageUpdatedEvent() : base(nameof(MessageUpdatedEvent))
    {
    }
    
    public string Message { get; set; }
}