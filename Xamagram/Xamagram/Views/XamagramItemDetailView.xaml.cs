using Xamagram.ViewModels;
using Xamarin.Forms;

namespace Xamagram.Views
{
    public partial class XamagramItemDetailView : ContentPage
    {
        public XamagramItemDetailView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;

            BindingContext = new XamagramItemDetailViewModel(Parameter);
        }

        public object Parameter { get; set; }
    }
}
