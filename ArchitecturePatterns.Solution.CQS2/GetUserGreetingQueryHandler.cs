using ArchitecturePatterns.Solution.CQS2.Mediator;

namespace ArchitecturePatterns.Solution.CQS2;

public class GetUserGreetingQueryHandler : IQueryHandler<GetUserGreetingQuery, string>
{
    private readonly LoginModel _model;

    public GetUserGreetingQueryHandler(LoginModel model)
    {
        _model = model;
    }

    public string Execute(GetUserGreetingQuery query)
    {
        return _model.GetMessage();
    }
}