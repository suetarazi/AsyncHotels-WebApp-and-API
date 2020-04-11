using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebAppAndAPI.Models.Interfaces;

namespace WebAppAndAPI.Models.Services
{
    interface HotelService : IHotelManager
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<List<Hotels>> GetAllHotels()
        {
            //get all the hotels fromt the third party API

            //set destination
            var baseUrl = @"https://asyncsolution.azurewebsites.net/api";
            string route = "hotels";

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var streamTask = await client.GetStreamAsync($"{baseUrl}/{route}");

            //converted to C# from JSON
            //var result = await JsonSerializer.DeserializeAsync<List<Hotels>>(streamTask);

            //return result;
            return null;

        }

        public Task GetHotelByID()
        {
            return null;
        }
    }
}
