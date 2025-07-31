using Tasker.ViewModels;
using Tasker.Views;

namespace Tasker
{
    public partial class App : Application
    {
        private readonly MainPageViewModel mainPageViewModel;

        public App(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            this.mainPageViewModel = mainPageViewModel;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPageView(mainPageViewModel));
        }
    }
}