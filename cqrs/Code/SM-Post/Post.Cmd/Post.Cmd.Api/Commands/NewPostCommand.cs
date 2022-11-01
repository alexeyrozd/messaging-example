using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public class NewPostCommand : CommandBase
{
    public string Author { get; set; }
    public string Message { get; set; }
}