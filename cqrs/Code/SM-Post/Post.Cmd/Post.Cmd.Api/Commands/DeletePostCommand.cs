using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public class DeletePostCommand : CommandBase
{
    public string Username { get; set; }
}