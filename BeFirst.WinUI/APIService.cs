using BeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using System.Windows.Forms;
using FlurlHttpException = Flurl.Http.FlurlHttpException;


namespace BeFirst.WinUI
{
    public class APIService
    {
        public static string KorisnickoIme { get; set; }
        public static string Password { get; set; }
  
        private string _route = null;

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                var result = await url.WithHeader("Nesto", "Nesto").WithBasicAuth(APIService.KorisnickoIme, APIService.Password).GetJsonAsync<T>();
                Console.WriteLine(await result.ToQueryString());
                Console.WriteLine(result.ToKeyValue());
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste autentificirani");
                }
                return default(T);
            }
        }
        public async Task<T> GetWithUrl<T>(object search, string suffix)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{suffix}";

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
                if (ex.Call.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }
        }
        public async Task<T> Get<T>()
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";


            var result = await url.WithBasicAuth(KorisnickoIme, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetById<T>(object Id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{Id}";

             return await url.WithBasicAuth(KorisnickoIme, Password).GetJsonAsync<T>();

        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            return await url.WithBasicAuth(KorisnickoIme, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> InsertWithoutAuth<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            return await url.WithBasicAuth(KorisnickoIme, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(KorisnickoIme, Password).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Delete<T>(object id)
        {
          
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(KorisnickoIme, Password).DeleteAsync().ReceiveJson<T>();
           

        }
    }
}
