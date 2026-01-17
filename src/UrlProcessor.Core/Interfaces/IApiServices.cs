namespace UrlProcessor.Core.Interface;
using UrlProcessor.Core.Model;

public interface IApiService
{
    public Task<WebData> GetWebDataAsync(string url);
    //Consult in the URL about the data that we define in our class WebData 
}