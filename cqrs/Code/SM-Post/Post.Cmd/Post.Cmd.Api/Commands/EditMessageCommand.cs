using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands;

public class EditMessageCommand : CommandBase
{
    public string Message { get; set; }
}