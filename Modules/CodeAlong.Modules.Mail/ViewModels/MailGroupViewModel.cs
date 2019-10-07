using System.Collections.ObjectModel;
using CodeAlong.Business;
using Prism.Mvvm;

namespace CodeAlong.Modules.Mail.ViewModels
{
    public class MailGroupViewModel:BindableBase
    {
        private ObservableCollection<NavigationItem> _items;
        public ObservableCollection<NavigationItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }
        public MailGroupViewModel()
        {
            Items=new ObservableCollection<NavigationItem>();
            GenerateMenu();
        }

        void GenerateMenu()
        {
            var root = new NavigationItem {Caption = "Personal Folder", NavigationPath = "MailList"};

            root.Items.Add(new NavigationItem { Caption = "Inbox", NavigationPath = "" }); 
            root.Items.Add(new NavigationItem { Caption = "Deleted", NavigationPath = "" }); 
            root.Items.Add(new NavigationItem { Caption = "Sent", NavigationPath = "" }); 
            
            Items.Add(root);
        }
    }
}