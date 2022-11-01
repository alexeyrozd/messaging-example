using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public class EditCommentCommand : CommandBase
{
    public Guid CommentId { get; set; }
    public string Comment { get; set; }
    public string Username { get; set; }
}