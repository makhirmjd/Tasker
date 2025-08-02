using CommunityToolkit.Mvvm.ComponentModel;

namespace Tasker.Models;

public partial class Category : ObservableObject
{
    public int Id { get; set; }
    public string CategoryName { get; set; } = default!;
    public string Color { get; set; } = default!;
    [ObservableProperty]
    private int pendingTasks;
    [ObservableProperty]
    private float percentage;
    [ObservableProperty]
    private bool isSelected;


    public List<MyTask> Tasks { get; set; } = [];

    public void RefreshPendingTasks()
    {
        int pendingTasks = Tasks.Count(t => !t.Completed);
        int totalTasks = Tasks.Count;
        int completedTasks = totalTasks - pendingTasks;
        PendingTasks = pendingTasks;
        Percentage = Tasks.Count == 0 ? 0 : (float)completedTasks / totalTasks;
    }
}
