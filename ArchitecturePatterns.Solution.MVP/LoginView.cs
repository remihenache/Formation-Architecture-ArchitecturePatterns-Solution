namespace ArchitecturePatterns.Solution.MVP;

public class LoginView : ILoginViewPresenter
{
    private LoginPresenter _presenter;

    public void SetPresenter(LoginPresenter presenter)
    {
        _presenter = presenter;
    }

    public string GetInput()
    {
        Console.WriteLine("Entrez votre nom :");
        return Console.ReadLine();
    }

    public void SetMessage(string text)
    {
        Console.WriteLine(text);
    }

    public void HandleSayHello()
    {
        _presenter.SayHello();
    }
}