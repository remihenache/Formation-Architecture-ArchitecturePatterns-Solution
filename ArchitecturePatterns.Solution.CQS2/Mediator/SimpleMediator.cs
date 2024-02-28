namespace ArchitecturePatterns.Solution.CQS2.Mediator;

public class SimpleMediator : IMediator
{
    private readonly SetUserNameCommandHandler setUserNameCommandHandler;
    private readonly GetUserGreetingQueryHandler getUserGreetingQueryHandler;

    public SimpleMediator(SetUserNameCommandHandler setUserNameCommand, GetUserGreetingQueryHandler getUserGreetingQuery)
    {
        this.setUserNameCommandHandler = setUserNameCommand;
        this.getUserGreetingQueryHandler = getUserGreetingQuery;
    }

    public void ExecuteCommand<T>(T command) where T : ICommand
    {
        if (command is SetUserNameCommand setUsernameCommand)
        {
            setUserNameCommandHandler.Execute(setUsernameCommand);
        }
    }

    public TResult ExecuteQuery<T, TResult>(T query)
        where T : IQuery<TResult> 
        where TResult : class
    {
        
        if (query is GetUserGreetingQuery getUserGreetingQuery)
        {
            return (getUserGreetingQueryHandler.Execute(getUserGreetingQuery) as TResult);
        }
        throw new InvalidOperationException("Query type not supported.");
    }
}