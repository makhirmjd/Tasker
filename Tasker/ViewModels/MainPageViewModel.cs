using System.Collections.ObjectModel;
using Tasker.Models;

namespace Tasker.ViewModels;

public class MainPageViewModel
{
    public ObservableCollection<Category> Categories { get; set; } = [];

    public MainPageViewModel()
    {
        FillData();
    }

    private void FillData() => Categories = [
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
}
