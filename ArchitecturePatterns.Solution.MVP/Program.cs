namespace ArchitecturePatterns.Solution.MVP;

class Program
{
    static void Main(string[] args)
    {
        var view = new LoginView();
        var presenter = new LoginPresenter();
        var model = new LoginModel();

        presenter.SetView(view);
        presenter.SetModel(model);

        // Simuler l'interaction utilisateur
        presenter.SayHello();
    }
}