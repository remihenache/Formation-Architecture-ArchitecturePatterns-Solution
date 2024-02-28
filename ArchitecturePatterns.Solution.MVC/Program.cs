namespace ArchitecturePatterns.Solution.MVC;

class Program
{
    static void Main(string[] args)
    {
        TaskModel model = new TaskModel();
        TaskView view = new TaskView();
        TaskController controller = new TaskController(model, view);
        controller.Run();
    }
}