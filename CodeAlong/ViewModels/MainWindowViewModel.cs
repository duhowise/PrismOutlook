using System;
using CodeAlong.Core;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace CodeAlong.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private string _title = "Prism Application";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        private DelegateCommand<string> _navigateCommand;
        public DelegateCommand<string> NavigateCommand =>
            _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigationCommand));

        private void ExecuteNavigationCommand(string navigationPath)
        {
            if (navigationPath == null) throw new ArgumentNullException(nameof(navigationPath));
            _regionManager.RequestNavigate(RegionNames.ContentRegion,navigationPath);
        }


        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }
    }
}
