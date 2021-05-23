using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeFirst.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OdgovoriPage : ContentPage
    {
        private ViewModels.OdgovoriViewModel model = null;

        public OdgovoriPage()
        {
            InitializeComponent();
            BindingContext = model = new ViewModels.OdgovoriViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as BeFirst.Models.Zahtjev;
            await Navigation.PushAsync(new OdgovoriDetalji((BeFirst.Models.Zahtjev)(e.SelectedItem)));
        }
    }
}