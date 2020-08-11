using System.ComponentModel;
using Xamarin.Forms;
using Spike1.ViewModels;

namespace Spike1.Views
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