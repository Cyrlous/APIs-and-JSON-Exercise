﻿using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            
            RonVSKanyeAPI.RonVSKanye(client);
        }
    }
}
