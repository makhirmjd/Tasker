using System.Collections.ObjectModel;
using Tasker.Models;

namespace Tasker.ViewModels;

public class MainPageViewModel
{
    public ObservableCollection<Category> Categories { get; set; } = [];
    public ObservableCollection<MyTask> Tasks { get; set; } = [];

    public MainPageViewModel()
    {
        FillData();
    }

    private void FillData()
    {
        Categories = [
        new()
        {
                Id = 1,
                CategoryName = ".NET MAUI Course",
                Color = "#CF14DF"
        },
        new()
        {
                Id = 2,
                CategoryName = "Tutorials",
                Color = "#df6f14"
        },
        new()
        {
                Id = 3,
                CategoryName = "Shopping",
                Color = "#14df80"
        }];

        Tasks = [
            new()
            {
                    TaskName = "Upload exercise files",
                    Completed = false,
                    CategoryId = 1
            },
            new()
            {
                    TaskName = "Plan next course",
                    Completed = false,
                    CategoryId = 1
            },
            new()
            {
                    TaskName = "Upload new ASP.NET video on YouTube",
                    Completed = false,
                    CategoryId = 2
            },
            new()
            {
                    TaskName = "Fix Settings.cs class of the project",
                    Completed = false,
                    CategoryId = 2
            },
            new()
            {
                    TaskName = "Update github repository",
                    Completed = true,
                    CategoryId = 2
            },
            new()
            {
                    TaskName = "Buy eggs",
                    Completed = false,
                    CategoryId = 3
            },
            new()
            {
                    TaskName = "Go for the pepperoni pizza",
                    Completed = false,
                    CategoryId = 3
            }];

        UpdateData();
    }

    public void UpdateData()
    {
        Categories.ToList().ForEach(c =>
        {
            int totalTasks = Tasks.Count(t => t.CategoryId == c.Id);
            int completedTasks = Tasks.Count(t => t.CategoryId == c.Id && t.Completed);
            c.PendingTasks = totalTasks - completedTasks;
            c.Percentage = (float)completedTasks / totalTasks * 100;
            Tasks.Where(t => t.CategoryId == c.Id).ToList().ForEach(t =>
            {
                t.TaskColor = c.Color;
            });
        });
    }
}
