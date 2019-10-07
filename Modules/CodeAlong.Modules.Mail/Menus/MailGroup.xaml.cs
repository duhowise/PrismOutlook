using CodeAlong.Core;
using Infragistics.Windows.OutlookBar;

namespace CodeAlong.Modules.Mail.Menus
{
    /// <summary>
    /// Interaction logic for MailGroup.xaml
    /// </summary>
    public partial class MailGroup : OutlookBarGroup,IOutlookBarGroup
    {
        public MailGroup()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => "MailList";
    }
}
