using Xamagram.Models;
using Xamarin.Forms;

namespace Xamagram.ViewModels
{
    public class XamagramItemDetailViewModel : BindableObject
    {
        private XamagramItem _item;

        public XamagramItemDetailViewModel(object parameter)
        {
            Item = parameter as XamagramItem;
        }

        public XamagramItem Item
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged("Item");
            }
        }
    }
}