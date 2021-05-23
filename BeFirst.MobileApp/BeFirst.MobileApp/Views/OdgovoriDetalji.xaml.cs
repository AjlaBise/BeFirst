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
    public partial class OdgovoriDetalji : ContentPage
    {
        private ViewModels.OdgovoriDetaljiViewModel viewModel;

        public OdgovoriDetalji(BeFirst.Models.Zahtjev zahtjevDetaljiViewModel)
        {
            InitializeComponent();
            BindingContext = viewModel = new OdgovoriDetaljiViewModel(zahtjevDetaljiViewModel);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.Init();
        }
    }
}