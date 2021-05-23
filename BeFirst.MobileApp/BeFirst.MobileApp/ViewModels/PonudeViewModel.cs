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
    public class PonudeViewModel
    {
        private readonly APIService _ponudeService = new APIService("Ponuda");

        public PonudeViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Ponuda> PonudaList { get; set; } = new ObservableCollection<Ponuda>();

        public ICommand InitCommand { get; set; }

       public async Task Init()
        {
            var list = await _ponudeService.Get<List<Ponuda>>();

            PonudaList.Clear();
            foreach (var ponuda in list)
            {
                PonudaList.Add(ponuda);
            }
        }
    }
}
