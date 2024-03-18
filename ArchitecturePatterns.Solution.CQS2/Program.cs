using ArchitecturePatterns.Solution.CQS2.Mediator;

namespace ArchitecturePatterns.Solution.CQS2;

class Program
{
    static void Main(string[] args)
    {
        var model = new LoginModel();
        var loginService = new LoginService();
        var setUserNameCommand = new SetUserNameCommandHandler(model);
        var getUserGreetingQuery = new GetUserGreetingQueryHandler(model);
        var mediator = new SimpleMediator(setUserNameCommand, getUserGreetingQuery);

        Console.WriteLine("Entrez votre nom :");
        var name = Console.ReadLine();

        mediator.ExecuteCommand(new SetUserNameCommand() { Name = name });
        var message = mediator.ExecuteQuery<GetUserGreetingQuery, string>(new GetUserGreetingQuery());
        Console.WriteLine(message);
    }
}