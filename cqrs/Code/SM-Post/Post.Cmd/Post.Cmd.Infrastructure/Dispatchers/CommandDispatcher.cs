using CQRS.Core.Commands;
using CQRS.Core.Infrastructure;

namespace Post.Cmd.Infrastructure.Dispatchers;

public class CommandDispatcher : ICommandDispatcher
{
    private readonly Dictionary<Type, Func<CommandBase, Task>> _handlers = new();
    
    public void RegisterHandler<T>(Func<T, Task> handler) where T : CommandBase
    {
        if (_handlers.ContainsKey(typeof(T)))
        {
            throw new IndexOutOfRangeException("handler already exists");
        }
        _handlers.Add(typeof(T), x=>handler((T)x));
    }

    public async Task SendAsync(CommandBase command)
    {
        if (_handlers.TryGetValue(command.GetType(), out Func<CommandBase, Task> handler))
        {
            await handler(command);
        }
        else
        {
            throw new ArgumentNullException($"{nameof(handler)} was not found");
        }
    }
}