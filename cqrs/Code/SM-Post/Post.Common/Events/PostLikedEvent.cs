using CQRS.Core.Events;

namespace Post.Common.Events;

public class PostLikedEvent : EventBase
{
    public PostLikedEvent() : base(nameof(PostLikedEvent))
    {
    }
}