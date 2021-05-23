using BeFirst.MobileApp.ViewModels;
using BeFirst.MobileApp.Views;
using BeFirst.Models;
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
    public partial class PonudePage : ContentPage
    {
        private ViewModels.PonudeViewModel model = null;


        public PonudePage()
        {
            InitializeComponent();
            BindingContext = model = new ViewModels.PonudeViewModel();
        }
     
        protected async override void OnAppearing()
        {
            base.OnAppearing();
           await model.Init();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as BeFirst.Models.Ponuda;
            await Navigation.PushAsync(new PonudaDetaljiPage((BeFirst.Models.Ponuda)(e.SelectedItem)));
        }
    }
}