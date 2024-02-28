namespace ArchitecturePatterns.Solution.MVC;

public class TaskController
{
    private readonly TaskModel model;
    private readonly TaskView view;

    public TaskController(TaskModel model, TaskView view)
    {
        this.model = model;
        this.view = view;
    }

    public void Run()
    {
        bool running = true;
        while (running)
        {
            view.ShowMenu();
            string option = view.GetUserInput("Choisissez une option: ");
            switch (option)
            {
                case "1":
                    string task = view.GetUserInput("Entrez la tâche: ");
                    model.AddTask(task);
                    view.ShowMessage("Tâche ajoutée.");
                    break;
                case "2":
                    view.ShowTasks(model.Tasks);
                    break;
                case "3":
                    view.ShowTasks(model.Tasks);
                    if (int.TryParse(view.GetUserInput("Entrez le numéro de la tâche à supprimer: "), out int taskNumber))
                    {
                        model.DeleteTask(taskNumber - 1);
                        view.ShowMessage("Tâche supprimée.");
                    }
                    else
                    {
                        view.ShowMessage("Numéro de tâche invalide.");
                    }
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    view.ShowMessage("Option invalide.");
                    break;
            }
        }
    }
}