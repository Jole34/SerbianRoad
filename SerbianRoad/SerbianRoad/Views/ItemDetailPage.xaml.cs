using SerbianRoad.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SerbianRoad.Views
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