namespace ArchitecturePatterns.Solution.CQS;

public class SetUserNameCommand
{
    private readonly LoginModel _model;

    public SetUserNameCommand(LoginModel model)
    {
        _model = model;
    }

    public void Execute(string name)
    {
        _model.Name = name;
    }
}