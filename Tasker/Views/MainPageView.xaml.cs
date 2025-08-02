using Tasker.ViewModels;

namespace Tasker.Views;

public partial class MainPageView : ContentPage
{
    private readonly MainPageViewModel viewModel;
    private readonly NewTaskPageViewModel newTaskPageViewModel;

    public MainPageView(MainPageViewModel viewModel, NewTaskPageViewModel newTaskPageViewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
        this.viewModel = viewModel;
        this.newTaskPageViewModel = newTaskPageViewModel;
    }

    private void TaskCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e) => viewModel.UpdateDataDynamically();

    private void Button_Clicked(object sender, EventArgs e)
    {
        newTaskPageViewModel.Categories = viewModel.Categories;
        newTaskPageViewModel.Tasks = viewModel.Tasks;
        NewTaskPageView taskPageView = new(newTaskPageViewModel);
        Navigation.PushAsync(taskPageView);
    }
}