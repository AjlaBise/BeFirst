using BeFirst.MobileApp.ViewModels;
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
    public partial class RadniNalogPage : ContentPage
    {
        RadniNalogViewModel model;
        public RadniNalogPage()
        {
            InitializeComponent();
            BindingContext = model = new RadniNalogViewModel();
        }

        protected async override void OnAppearing()
        {
            await model.Init();
            base.OnAppearing();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RadniNalogPage();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RadniNalogPage();
        }
    }
}