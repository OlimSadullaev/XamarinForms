using System.ComponentModel;
using Transactions.ViewModels;
using Xamarin.Forms;

namespace Transactions.Views
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