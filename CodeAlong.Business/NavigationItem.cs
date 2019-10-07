using System.Collections.ObjectModel;

namespace CodeAlong.Business
{
    public class NavigationItem
    {
        public NavigationItem()
        {
            Items=new ObservableCollection<NavigationItem>();
        }
        public string Caption { get; set; }
        public string NavigationPath { get; set; }
        public ObservableCollection<NavigationItem> Items { get; set; } 

    }
}