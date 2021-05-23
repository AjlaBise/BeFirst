using BeFirst.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeFirst.MobileApp.ViewModels
{
    public class PonudeDetaljiViewModel : BaseViewModel
    {
        public Ponuda Ponuda { get; set; }

        //public PonudeDetaljiViewModel(Ponuda ponuda = null)
        //{
        //    Title = ponuda?.Naziv;
        //    Ponuda = ponuda;
        //}
        public BeFirst.Models.Ponuda _ponuda = null;

        public PonudeDetaljiViewModel()
        {
            InitCommand = new Command(() => Init());
        }

        public PonudeDetaljiViewModel(Ponuda ponuda)
        {
            _ponuda = ponuda;
            InitCommand = new Command(() => Init());
        }
        public ObservableCollection<Ponuda> PonudaList { get; set; } = new ObservableCollection<Ponuda>();

        public ICommand InitCommand { get; set; }

        public void Init()
        {

            PonudaList.Clear();

            PonudaList.Add(_ponuda);

        }
    }
}
