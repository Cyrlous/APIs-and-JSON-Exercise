using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    static internal class RonVSKanyeAPI
    {
        static public void RonVSKanye(HttpClient client)
        {
            var kanyeAPI = "https://api.kanye.rest";
            var ronAPI = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            
            for (int i = 0; i < 5; i++)
            {
                var kanyeResponse = client.GetStringAsync(kanyeAPI).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                Console.WriteLine($"Kanye: {kanyeQuote}\n");
                
                var ronResponse = client.GetStringAsync(ronAPI).Result;
                var ronQuote = JArray.Parse(ronResponse);
                Console.WriteLine($"Ron: {ronQuote[0]}\n");
            }
        }
    }
}
