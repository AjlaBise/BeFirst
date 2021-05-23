using BeFirst.MobileApp.Views;
using BeFirst.Models;
using BeFirst.Models.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BeFirst.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService serviceKorisnik = new APIService("Korisnik");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => Login());

        }

        int _UserId = 0;
        public int UserId
        {
            get { return _UserId; }
            set { SetProperty(ref _UserId, value); }
        }


        string _Username = "BeFirstKorisnik";
        public string Username
        {
            get { return _Username; }
            set { SetProperty(ref _Username, value); }
        }

        string _Password = "korisnik123";
        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }

        public ICommand LoginCommand { get; set; }

        public async Task Login()
        {
            APIService.KorisnickoIme = Username;
            APIService.Password = Password;

            try
            {
                var request = new AuthenticateRequest()
                {
                    Username = Username,
                    Password = Password
                };

                var response = await new APIService("Account").Insert<Account>(request);

                if (response != null)
                {
                    foreach(var user in response.Korisnik)
                    {
                        APIService.LoggedUserID = user.Id;
                        break;
                    }

                    if (response.Uloga.Id == 4)
                        Application.Current.MainPage = new RadniNalogPage();
                
                    if (response.Uloga.Id == 2)
                    {
                    
                        APIService.UserID = response.Korisnik;
                        Application.Current.MainPage = new MainPage();
                    
                    }
                }
                else
                    await Application.Current.MainPage.DisplayAlert("Greška", "Pogrešni podaci!", "Ok");

            }
            catch (Exception ex)
            {
                //throw;
            }

        }
    }

}
