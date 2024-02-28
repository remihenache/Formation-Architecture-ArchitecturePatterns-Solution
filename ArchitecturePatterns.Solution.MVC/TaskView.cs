namespace ArchitecturePatterns.Solution.MVC;

public class TaskView
{
    public void ShowMenu()
    {
        Console.WriteLine("\nGestionnaire de Tâches:");
        Console.WriteLine("1. Ajouter une tâche");
        Console.WriteLine("2. Afficher les tâches");
        Console.WriteLine("3. Supprimer une tâche");
        Console.WriteLine("4. Quitter");
    }

    public void ShowTasks(List<string> tasks)
    {
        Console.WriteLine("\nTâches:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    public string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}