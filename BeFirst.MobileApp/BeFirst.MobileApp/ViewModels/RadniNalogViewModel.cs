using BeFirst.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeFirst.MobileApp.ViewModels
{
    public class RadniNalogViewModel : BaseViewModel
    {
        private readonly APIService serviceRadniNalog = new APIService("RadniNalog");
        private readonly APIService serviceUposlenik = new APIService("Uposlenik");
        private readonly APIService serviceOprema = new APIService("Oprema");
        private readonly APIService serviceOpremaUposlenikRadniNalog = new APIService("OpremaUposlenikRadniNalog");


        public RadniNalogViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SaveCommand = new Command(async () => await SaveChanges());

        }


        Uposlenik _selectedUposlenik = null;
        public Uposlenik selectedUposlenik
        {
            get { return _selectedUposlenik; }
            set { SetProperty(ref _selectedUposlenik, value); }
        }

        Oprema _selectedOprema = null;
        public Oprema selectedOprema
        {
            get { return _selectedOprema; }
            set { SetProperty(ref _selectedOprema, value); }
        }

        string _selectedIme = string.Empty;
        public string selectedIme
        {
            get { return _selectedIme; }
            set { SetProperty(ref _selectedIme, value); }
        }

        string _selectedPrezime = string.Empty;
        public string selectedPrezime
        {
            get { return _selectedPrezime; }
            set { SetProperty(ref _selectedPrezime, value); }
        }

        string _selectedAdresa = string.Empty;
        public string selectedAdresa
        {
            get { return _selectedAdresa; }
            set { SetProperty(ref _selectedAdresa, value); }
        }


        string _OpisPrijavljenogPosla = string.Empty;
        public string selectOpisPrijavljenogPosla
        {
            get { return _OpisPrijavljenogPosla; }
            set { SetProperty(ref _OpisPrijavljenogPosla, value); }
        }


        string _OpisIzvrsenogPosla = string.Empty;
        public string selectedOpisIzvrsenogPosla
        {
            get { return _OpisIzvrsenogPosla; }
            set { SetProperty(ref _OpisIzvrsenogPosla, value); }
        }

        DateTime _Datum = DateTime.Now;
        public DateTime selectedDatum
        {
            get { return _Datum; }
            set { SetProperty(ref _Datum, value); }
        }


        public ObservableCollection<Uposlenik> UposlenikList { get; set; } = new ObservableCollection<Uposlenik>();
        public ObservableCollection<Oprema> OpremaList { get; set; } = new ObservableCollection<Oprema>();


        public ICommand InitCommand { get; set; }
        public async Task Init()
        {

            if (UposlenikList.Count == 0)
            {
                var resposeUposlenikList = await serviceUposlenik.Get<List<Uposlenik>>(null);
                foreach (var uposlenik in resposeUposlenikList)
                {
                    UposlenikList.Add(uposlenik);
                }
            }

            if (OpremaList.Count == 0)
            {
                var resposneradniOpremaList = await serviceOprema.Get<List<Oprema>>(null);
                foreach (var oprema in resposneradniOpremaList)
                {
                    OpremaList.Add(oprema);
                }
            }

        }

        public ICommand SaveCommand { get; set; }

        public async Task SaveChanges()
        {

            if (selectedDatum == null)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Unesite datum za radni nalog!", "Ok");
                return;
            }

            ////potrebno napraviti dropdown pa ovo otkmentarisati
            //if (selectedUposlenik == null)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite uposlenika!", "Ok");
            //    return;
            //}

            //if (selectedOprema == null)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Greška", "Odaberite opremu!", "Ok");
            //    return;
            //}

            var request = new RadniNalog()
            {
                Adresa = selectedAdresa,
                Datum = selectedDatum,
                KorisnikId = 1,
                OpisIzvrsenogPosla = selectedOpisIzvrsenogPosla,
                OpisPrijavljenogPosla = selectOpisPrijavljenogPosla,
                KorisnikIme = selectedIme,
                KorisnikPrezime = selectedPrezime

            };
            var RadniNalogResponse = await serviceRadniNalog.Insert<RadniNalog>(request);

            //dodavanje opremaUposlenikRadniNalog
            var requestOpremaUposlenikRadniNalog = new OpremaUposlenikRadniNalog()
            {
                RadniNalogId = RadniNalogResponse.Id,

                /////kada se uradi dropdown ovo treba odkomentarisati
                //UposlenikId = selectedUposlenik.Id,
                //OpremaId = selectedOprema.Id,

                UposlenikId = 1,
                OpremaId = 1,
            };
            var modelracun = await serviceOpremaUposlenikRadniNalog.Insert<OpremaUposlenikRadniNalog>(requestOpremaUposlenikRadniNalog);


            await Application.Current.MainPage.DisplayAlert("Notifikacija", "Radni nalog uspješno kreiran!", "Ok");


        }
    }
}
