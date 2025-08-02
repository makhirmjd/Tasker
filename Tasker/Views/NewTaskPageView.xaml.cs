using Tasker.ViewModels;

namespace Tasker.Views;

public partial class NewTaskPageView : ContentPage
{
    private readonly NewTaskPageViewModel viewModel;

    public NewTaskPageView(NewTaskPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
        this.viewModel = viewModel;
    }

    private void AddTaskClicked(object sender, EventArgs e) => viewModel.AddTask(Navigation, this);

    private async void AddCategoryClicked(object sender, EventArgs e) => await viewModel.AddCategory(Navigation, this);
}