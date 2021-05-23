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
    public class OdgovoriViewModel
    {
        private readonly APIService _ponudeService = new APIService("GetZahtjeve");

        public OdgovoriViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Zahtjev> OdgovoriList { get; set; } = new ObservableCollection<Zahtjev>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _ponudeService.GetWithUrl<List<Zahtjev>>(null, APIService.LoggedUserID.ToString());

            OdgovoriList.Clear();

            foreach (var odgovor in list)
            {
                OdgovoriList.Add(odgovor);
            }
           
        }
    }
}
