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
}