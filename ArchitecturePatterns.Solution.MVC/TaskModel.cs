namespace ArchitecturePatterns.Solution.MVC;

public class TaskModel
{
    public List<string> Tasks { get; private set; } = new List<string>();

    public void AddTask(string task)
    {
        Tasks.Add(task);
    }

    public void DeleteTask(int index)
    {
        if (index >= 0 && index < Tasks.Count)
        {
            Tasks.RemoveAt(index);
        }
    }
}