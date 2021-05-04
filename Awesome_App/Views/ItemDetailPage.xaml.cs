using Awesome_App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Awesome_App.Views
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