using ArchitecturePatterns.Solution.CQS2.Mediator;

namespace ArchitecturePatterns.Solution.CQS2;

public class GetUserGreetingQueryHandler : IQueryHandler<GetUserGreetingQuery, string>
{
    private readonly LoginModel _model;
    private readonly LoginService _loginService;

    public GetUserGreetingQueryHandler(LoginModel model, LoginService loginService)
    {
        _model = model;
        _loginService = loginService;
    }

    public string Execute(GetUserGreetingQuery query)
    {
        return _loginService.SayHello(_model.Name);
    }
}