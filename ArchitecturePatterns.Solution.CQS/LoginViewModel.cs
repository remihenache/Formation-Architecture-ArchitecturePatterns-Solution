using System.ComponentModel;

namespace ArchitecturePatterns.Solution.CQS;

public class LoginViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private string _input;
    private string _message;
    private readonly LoginModel _model = new LoginModel();

    public string Input
    {
        get => _input;
        set
        {
            if (_input == value) return;
            _input = value;
            OnPropertyChanged(nameof(Input));
            new SetUserNameCommand(_model).Execute(_input);
            _message = new GetUserGreetingQuery(_model).Execute();
            OnPropertyChanged(nameof(Message));
        }
    }

    public string Message
    {
        get => _message;
        private set
        {
            _message = value;
            OnPropertyChanged(nameof(Message));
        }
    }

    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
