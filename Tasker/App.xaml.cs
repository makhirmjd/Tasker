using Tasker.ViewModels;
using Tasker.Views;

namespace Tasker
{
    public partial class App : Application
    {
        private readonly MainPageViewModel mainPageViewModel;
        private readonly NewTaskPageViewModel newTaskPageViewModel;

        public App(MainPageViewModel mainPageViewModel, NewTaskPageViewModel newTaskPageViewModel)
        {
            InitializeComponent();
            this.mainPageViewModel = mainPageViewModel;
            this.newTaskPageViewModel = newTaskPageViewModel;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new MainPageView(mainPageViewModel));
            return new Window(new NavigationPage(new MainPageView(mainPageViewModel, newTaskPageViewModel)));
        }
    }
}