using CQRS.Core.Events;

namespace Post.Common.Events;

public class CommentAddedEvent : EventBase
{
    public CommentAddedEvent() : base(nameof(CommentAddedEvent))
    {
    }
    
    public Guid CommentId { get; set; }
    public string Comment { get; set; }
    public string Username { get; set; }
    public DateTime CommentDate { get; set; }
}