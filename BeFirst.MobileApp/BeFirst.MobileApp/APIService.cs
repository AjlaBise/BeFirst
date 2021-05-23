using BeFirst.MobileApp.ViewModels;
using BeFirst.Models;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeFirst.MobileApp
{
    public class APIService
    {
        public static string KorisnickoIme { get; set; }
        public static string Password { get; set; }
        public static ICollection<Korisnik> UserID { get; set; }
        public static int LoggedUserID { get; set; }


        private string _route = null;
#if DEBUG
        private string APIUrl = "http://localhost:5000/api";
#endif

#if RELEASE
        private string APIUrl = "https://mywebsite.com/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{APIUrl}/{_route}";

            try
            {
                
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                
                return await url.WithBasicAuth(KorisnickoIme, Password).GetJsonAsync<T>();

            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                }
                throw;
            }
        }
        public async Task<T> GetWithUrl<T>(object search, string suffix)
        {
            var url = $"{APIUrl}/{_route}/{suffix}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += search.ToString();
                }

                return await url.WithBasicAuth(KorisnickoIme, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autentificirani", "OK");
                }
                throw;
            }
        }
        public async Task<T> Get<T>()
        {
            var url = $"{APIUrl}/{_route}";


            var result = await url.WithBasicAuth(KorisnickoIme, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetById<T>(object Id)
        {
            var url = $"{APIUrl}/{_route}/{Id}";

            return await url.WithBasicAuth(KorisnickoIme, Password).GetJsonAsync<T>();

        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{APIUrl}/{_route}";

            return await url.WithBasicAuth(KorisnickoIme, Password).PostJsonAsync(request).ReceiveJson<T>();

        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{APIUrl}/{_route}/{id}";
            var result = await url.WithBasicAuth(KorisnickoIme, Password).PatchJsonAsync(request).ReceiveJson<T>();

            return result;

        }

        public async Task<T> Delete<T>(object id)
        {

            var url = $"{APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Password).DeleteAsync().ReceiveJson<T>();


        }
    }
}
