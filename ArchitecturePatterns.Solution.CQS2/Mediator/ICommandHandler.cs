namespace ArchitecturePatterns.Solution.CQS2.Mediator;

public interface ICommandHandler<TCommand> where TCommand : ICommand
{
    void Execute(TCommand command);
}