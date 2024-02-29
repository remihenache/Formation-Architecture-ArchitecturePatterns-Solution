namespace ArchitecturePatterns.Solution.MVP;

public interface ILoginViewPresenter
{
    string GetInput();
    void SetMessage(string text);
}