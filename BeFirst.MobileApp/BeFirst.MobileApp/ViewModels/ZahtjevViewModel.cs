using BeFirst.Models;
using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeFirst.MobileApp.ViewModels
{
    public class ZahtjevViewModel : BaseViewModel
    {
        private readonly APIService _zahtjevService = new APIService("Zahtjev");

        public ZahtjevViewModel()
        {
            InitCommand = new Command(() => Init());
        }

        string _Naslov = string.Empty;
        public string Naslov
        {
            get { return _Naslov; }
            set { SetProperty(ref _Naslov, value); }
        }

        string _Opis = string.Empty;
        public string Opis
        {
            get { return _Opis; }
            set { SetProperty(ref _Opis, value); }
        }

        public ObservableCollection<Zahtjev> ZahtjevList { get; set; } = new ObservableCollection<Zahtjev>();
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            try
            {
                if (string.IsNullOrEmpty(Naslov))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti Naslov", "Ok");
                    return;
                }
                if (string.IsNullOrEmpty(Opis))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Morate unijeti Opis", "Ok");
                    return;
                }

                var req = new ZahtjevUpsertRequest()
                {
                    Opis = Opis,
                    Naslov = Naslov,
                    KorisnikID = 1
                };

                var zahtjev = await _zahtjevService.Insert<Zahtjev>(req);
                await Application.Current.MainPage.DisplayAlert("Success", "Uspješno ste postavili zahtjev", "Ok");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Došlo je do greške!!!", "Ok");

                throw;
            }

        }


    }
}
