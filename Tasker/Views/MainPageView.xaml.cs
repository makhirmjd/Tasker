using Tasker.ViewModels;

namespace Tasker.Views;

public partial class MainPageView : ContentPage
{
    private readonly MainPageViewModel viewModel;

    public MainPageView(MainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
        this.viewModel = viewModel;
    }

    private void TaskCheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e) => viewModel.UpdateDataDynamically();
}