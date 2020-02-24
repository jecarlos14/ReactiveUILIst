using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reactive;
using ReactiveUI;

namespace ReactiveUILIst
{
    public class MainPageViewModel : ReactiveObject
    {
        public ReactiveCommand<object, Unit> SelectedProjectCommand
        {
            get;
            protected set;
        }

        private ObservableCollection<object> projects;
        public ObservableCollection<object> Projects
        {
            get => projects;
            set => this.RaiseAndSetIfChanged(ref projects, value);
        }

        public MainPageViewModel()
        {
            //TODO: Change this
            Projects = new ObservableCollection<object>()
            {
                new object(),
                new object(),
                new object()
            };

            SelectedProjectCommand = ReactiveCommand.Create<object>(Test);
        }

        private void Test(object obj)
        {
            Debug.WriteLine("Hola");
        }
    }
}
