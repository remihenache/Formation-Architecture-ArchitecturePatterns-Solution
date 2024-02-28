using ArchitecturePatterns.Solution.CQS2.Mediator;

namespace ArchitecturePatterns.Solution.CQS2;

public class SetUserNameCommand : ICommand
{
    public string Name { get; set; }
}