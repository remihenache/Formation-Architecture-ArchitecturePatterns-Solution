namespace ArchitecturePatterns.Solution.MVP;

public class LoginView : ILoginViewPresenter
{

    public string GetInput()
    {
        Console.WriteLine("Entrez votre nom :");
        return Console.ReadLine();
    }

    public void SetMessage(string text)
    {
        Console.WriteLine(text);
    }

}