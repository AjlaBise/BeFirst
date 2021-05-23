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
    public partial class PonudaDetaljiPage : ContentPage
    {
        private ViewModels.PonudeDetaljiViewModel viewModel;

        public PonudaDetaljiPage(BeFirst.Models.Ponuda ponudeDetaljiViewModel)
        {
            InitializeComponent();
            BindingContext = viewModel = new PonudeDetaljiViewModel(ponudeDetaljiViewModel);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.Init();
        }
    }
}