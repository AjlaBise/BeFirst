using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BeFirst.MobileApp.Models;
using BeFirst.MobileApp.Views;
using BeFirst.MobileApp.ViewModels;
using BeFirst.Models;

namespace BeFirst.MobileApp.Views
{

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        PaketViewModel model = null;

        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = model = new PaketViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Recommended();

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Paket;
            //await Navigation.PushAsync(new DetaljiVozilaPage((Vozilo)(e.SelectedItem)));
        }
    }
}