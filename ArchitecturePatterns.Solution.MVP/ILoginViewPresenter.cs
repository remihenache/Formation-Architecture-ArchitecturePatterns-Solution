namespace ArchitecturePatterns.Solution.MVP;

public interface ILoginViewPresenter
{
    string GetInput();
    void SetPresenter(LoginPresenter presenter);
    void SetMessage(string text);
}