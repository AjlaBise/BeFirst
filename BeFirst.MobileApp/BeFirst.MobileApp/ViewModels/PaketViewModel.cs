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
    public class PaketViewModel : BaseViewModel
    {
        private readonly APIService _RecommenderService = new APIService("Recommender");

        public PaketViewModel()
        {
            RecommendedCommand = new Command(async () => await Recommended());
        }


        public ObservableCollection<Paket> SlicniPaketi { get; set; } = new ObservableCollection<Paket>();
        public ObservableCollection<Paket> SnizeniPaketi { get; set; } = new ObservableCollection<Paket>();
        public ICommand RecommendedCommand { get; set; }
        public async Task Recommended()
        {

            var RecommenderModel = await _RecommenderService.Get<RecommenderModel>(APIService.LoggedUserID);

            SlicniPaketi.Clear();
            foreach (var x in RecommenderModel.SlicniPaketi)
            {
                SlicniPaketi.Add(x);
            }
            SnizeniPaketi.Clear();
            foreach (var x in RecommenderModel.SnizeniPaketi)
            {
                SnizeniPaketi.Add(x);
            }

        }

    }
}