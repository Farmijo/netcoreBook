using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace LanguageProperties.Models
{
    public class MyAsyncMethods
    {

        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpMessage = await client.GetAsync("http://apress.com");
            return httpMessage.Content.Headers.ContentLength;
        }

    }
}
