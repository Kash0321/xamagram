using Xamagram.Models;
using Xamagram.ViewModels;
using Xamarin.Forms;

namespace Xamagram.Views
{
    public partial class XamagramItemsView : ContentPage
    {
        private XamagramItemsViewModel _vm;
        public XamagramItemsView()
        {
            InitializeComponent();

            _vm = new XamagramItemsViewModel();

            BindingContext = _vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SubscribeFromMessages();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            UnsubscribeFromMessages();
        }
        private void SubscribeFromMessages()
        {
            MessagingCenter.Subscribe<XamagramItem>(
                this, 
                GlobalSettings.DetailNavigation, 
                async (parameter) =>
            {
                await Navigation.PushAsync(new XamagramItemDetailView(parameter), true);
            });
        }

        private void UnsubscribeFromMessages()
        {
            MessagingCenter.Unsubscribe<XamagramItem>(this,
                GlobalSettings.DetailNavigation);
        }
    }
}
