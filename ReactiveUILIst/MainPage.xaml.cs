using System.ComponentModel;
using System.Reactive.Disposables;
using ReactiveUI;
using ReactiveUI.XamForms;

namespace ReactiveUILIst
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ReactiveContentPage<MainPageViewModel>
    {
        public MainPage()
        {
            InitializeComponent();

            ViewModel = new MainPageViewModel();

            this.WhenActivated(
   disposable =>
   {
       this
          .OneWayBind(ViewModel, vm => vm.Projects, v => v.ProjectsListView.ItemsSource)
          .DisposeWith(disposable);
       this
         .BindCommand(ViewModel, vm => vm.SelectedProjectCommand, v => v.ProjectsListView, nameof(ProjectsListView.ItemSelected))
         .DisposeWith(disposable);
            });
        }
    }
}
 