using BeFirst.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeFirst.MobileApp.ViewModels
{
    public class OdgovoriDetaljiViewModel
    {
        public Zahtjev Zahtjev { get; set; }


        public BeFirst.Models.Zahtjev _zahtjev = null;

        public OdgovoriDetaljiViewModel()
        {
            InitCommand = new Command(() => Init());
        }

        public OdgovoriDetaljiViewModel(Zahtjev zahtjev)
        {
            _zahtjev = zahtjev;
            InitCommand = new Command(() => Init());
        }
        public ObservableCollection<Zahtjev> OdgovorList { get; set; } = new ObservableCollection<Zahtjev>();

        public ICommand InitCommand { get; set; }

        public void Init()
        {

            OdgovorList.Clear();

            OdgovorList.Add(_zahtjev);

        }
    }
}
