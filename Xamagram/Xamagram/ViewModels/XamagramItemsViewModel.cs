using System.Collections.ObjectModel;
using Xamagram.Models;
using Xamagram.Services;
using Xamarin.Forms;

namespace Xamagram.ViewModels
{
    public class XamagramItemsViewModel : BindableObject
    {
        private ObservableCollection<XamagramItem> _items;
        private XamagramItem _selectedItem;

        public XamagramItemsViewModel()
        {
            Items = XamagramService.Instance.GetItems();
        }

        public ObservableCollection<XamagramItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        public XamagramItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;

                // Utilizando mensajería
                MessagingCenter.Send(_selectedItem, GlobalSettings.DetailNavigation);

                // Creando un servicio de navegación
                // NavigationService.Instance.NavigateTo<XamagramItemDetailViewModel>(_selectedItem);
            }
        }
    }
}
