namespace ArchitecturePatterns.Solution.MVP;

public class LoginPresenter
{
    private LoginModel _model;
    private ILoginViewPresenter _view;

    public void SetModel(LoginModel model)
    {
        _model = model;
    }

    public void SetView(ILoginViewPresenter view)
    {
        _view = view;
    }

    public void SayHello()
    {
        var input = _view.GetInput();
        _model.Name = input;
        _view.SetMessage(_model.GetMessage());
    }
}