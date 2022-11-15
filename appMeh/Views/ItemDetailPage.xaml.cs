using appMeh.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace appMeh.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}