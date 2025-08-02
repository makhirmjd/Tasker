using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Tasker.Models;

namespace Tasker.ViewModels;

public partial class NewTaskPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string task;
    public ObservableCollection<MyTask> Tasks { get; set; } = [];
    public ObservableCollection<Category> Categories { get; set; } = [];

    public void AddTask(INavigation navigation, ContentPage? shell = default!)
    {
        Category? selectedCategory = Categories.FirstOrDefault(x => x.IsSelected);
        if (selectedCategory is not null)
        {
            MyTask task = new()
            {
                TaskName = Task,
                CategoryId = selectedCategory.Id,
                TaskColor = selectedCategory.Color
            };
            Tasks.Add(task);
            selectedCategory.Tasks.Add(task);
            selectedCategory.RefreshPendingTasks();
            navigation.PopAsync();
        }
        else
        {
            shell?.DisplayAlert("Invalid Selection", "You must select a category", "Ok");
        }
    }

    public async Task AddCategory(INavigation navigation, ContentPage shell)
    {
        string? category = await shell.DisplayPromptAsync("New Category", "Write the new category name", maxLength: 15, keyboard: Keyboard.Text);
        if (!string.IsNullOrEmpty(category))
        {
            Random random = Random.Shared;
            Categories.Add(new()
            {
                Id = Categories.Max(x => x.Id) + 1,
                Color = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256)).ToHex(),
                CategoryName = category
            });
        }
    }
}
