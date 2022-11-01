using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public class AddCommentCommand : CommandBase
{
    public string Comment { get; set; }
    public string Username { get; set; }
}