namespace Tasker.Models;

public class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; } = default!;
    public string Color { get; set; } = default!;
    public int PendingTasks { get; set; }
    public float Percentage { get; set; }
}
