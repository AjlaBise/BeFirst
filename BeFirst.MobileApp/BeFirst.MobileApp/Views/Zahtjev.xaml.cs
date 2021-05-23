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
    public partial class Zahtjev : ContentPage
    {
        private ViewModels.ZahtjevViewModel model = null;

        public Zahtjev()
        {
            InitializeComponent();
            BindingContext = model = new ViewModels.ZahtjevViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
        }


        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as BeFirst.Models.Zahtjev;
            //await Navigation.PushAsync(new PonudaDetaljiPage((BeFirst.Models.Ponuda)(e.SelectedItem)));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.Init();
            Application.Current.MainPage = new MainPage();
        }
    }
}