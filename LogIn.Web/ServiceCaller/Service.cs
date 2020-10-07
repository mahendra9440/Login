using LogIn.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace LogIn.Web.ServiceCaller
{
    public class Service
    {
        public const string BaseUrl = "https://localhost:44339/api/Login";

        public static async Task<bool> validate(string UserName,string PWD)
        {
            bool result;
            using (HttpClient client=new HttpClient())
            {
                Uri uri = new Uri(BaseUrl);
                client.BaseAddress = uri;
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
               var response=await client.GetAsync("Validate/"+ UserName+"/"+ PWD);
                if(response.IsSuccessStatusCode)
                {
                    result = JsonConvert.DeserializeObject<bool>( response.Content.ReadAsStringAsync().Result);
                    return result;
                }
                return false;
               
            }
        }
        
    }
}