namespace UrlProcessor.App.Services;

using System.Data;
using System.Diagnostics;
using System.Net;
using UrlProcessor.Core.Interface;
using UrlProcessor.Core.Model;

public class ApiService : IApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient obj_httpClient)
    {
        //Define in the constructor the HTTP Client
        _httpClient = obj_httpClient;
    }

    public async Task<WebData> GetWebDataAsync(string url)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        try
        {
            //Trying the HTTP petition
            var response = await _httpClient.GetAsync(url);
            stopwatch.Stop();

            return new WebData()
            {
                //Creation of the object WebData
                Url = url,
                Exito = response.IsSuccessStatusCode,
                TimeSpan = stopwatch.Elapsed,
                TimeDate = DateTime.Now,
                StatusCode = (int)response.StatusCode
            };
        }

        catch (Exception ex)
        {
            //If the HTTP petition fails
            stopwatch.Stop();
            return new WebData()
            {
                //Creation of the WebData object with the information of the error
                Url = url,
                Exito = false,
                TimeSpan = stopwatch.Elapsed,
                TimeDate = DateTime.Now,
                StatusCode = 0,
                ErrorException = ex.Message
            };
        }

    }
}
