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

public class GetUserGreetingQuery
{
    private readonly LoginModel _model;
    private readonly LoginService _loginService;

    public GetUserGreetingQuery(LoginModel model, LoginService loginService)
    {
        _model = model;
        _loginService = loginService;
    }

    public string Execute()
    {
        return _loginService.SayHello(_model.Name);
    }
}


class Program
{
    static void Main(string[] args)
    {
        var viewModel = new LoginViewModel();
        var view = new LoginView(viewModel);

        // Simuler l'interaction de l'utilisateur continuellement
        while (true)
        {
            view.GetUserInput();
        }
    }
}