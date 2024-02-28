namespace ArchitecturePatterns.Solution.CQS2;

public class LoginService
{
    public string SayHello(string name)
    {
        return string.IsNullOrEmpty(name) ? "Bonjour inconnu" : $"Bonjour {name}";
    }
}