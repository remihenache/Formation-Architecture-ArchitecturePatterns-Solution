namespace ArchitecturePatterns.Solution.CQS;

public class GetUserGreetingQuery
{
    private readonly LoginModel _model;

    public GetUserGreetingQuery(LoginModel model)
    {
        _model = model;
    }

    public string Execute()
    {
        return _model.GetMessage();
    }
}