using UrlProcessor.Core.Model;

interface IApiService
{
    public Task<WebData> GetWebDataAsync(string url);
    //Consult in the URL about the data that we define in our class WebData 
}