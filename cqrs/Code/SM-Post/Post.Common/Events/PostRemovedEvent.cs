using CQRS.Core.Events;

namespace Post.Common.Events;

public class PostRemovedEvent : EventBase
{
    public PostRemovedEvent() : base(nameof(PostRemovedEvent))
    {
    }
}