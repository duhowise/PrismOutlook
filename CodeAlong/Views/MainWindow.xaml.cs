using Infragistics.Themes;
using Infragistics.Windows.Ribbon;

namespace CodeAlong.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : XamRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ThemeManager.ApplicationTheme = new Office2013Theme();
        }
    }
}
