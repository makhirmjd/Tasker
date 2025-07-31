namespace Tasker.Models;

public class MyTask
{
    public string TaskName { get; set; } = default!;
    public bool Completed { get; set; }
    public int CategoryId { get; set; }
    public string TaskColor { get; set; } = default!;
}
