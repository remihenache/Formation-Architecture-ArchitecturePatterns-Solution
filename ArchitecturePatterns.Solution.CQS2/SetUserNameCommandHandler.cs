using ArchitecturePatterns.Solution.CQS2.Mediator;

namespace ArchitecturePatterns.Solution.CQS2;

public class SetUserNameCommandHandler : ICommand
{
    private readonly LoginModel model;

    public SetUserNameCommandHandler(LoginModel model)
    {
        this.model = model;
    }

    public void Execute(SetUserNameCommand command)
    {
        model.Name = command.Name;
    }
}