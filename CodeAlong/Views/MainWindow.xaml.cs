using System;
using CodeAlong.Core;
using Infragistics.Themes;
using Infragistics.Windows.OutlookBar;
using Infragistics.Windows.Ribbon;
using Prism.Regions;

namespace CodeAlong.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : XamRibbonWindow
    {
        private readonly IRegionManager _regionManager;

        public MainWindow(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            InitializeComponent();
            XamOutlookBar.SelectedGroupChanged += XamOutlookBar_SelectedGroupChanged;
            ThemeManager.ApplicationTheme = new Office2013Theme();
        }

        private void XamOutlookBar_SelectedGroupChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            var group = ((XamOutlookBar) sender).SelectedGroup as IOutlookBarGroup;
            if (group == null) throw new ArgumentNullException(nameof(group));

            //navigate
            _regionManager.RequestNavigate(RegionNames.ContentRegion,group.DefaultNavigationPath);
        }
    }
}
