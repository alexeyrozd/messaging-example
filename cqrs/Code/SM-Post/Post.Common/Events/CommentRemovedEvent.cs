using CQRS.Core.Events;

namespace Post.Common.Events;

public class CommentRemovedEvent : EventBase
{
    public CommentRemovedEvent() : base(nameof(CommentRemovedEvent))
    {
    }
    
    public Guid CommentId { get; set; }
}