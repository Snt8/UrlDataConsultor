namespace UrlProcessor.App;
using UrlProcessor.Core.Model;
using UrlProcessor.Core.Interface;

public class Processor
{
    private readonly IFileService _fileAction; //Create the File service process
    private readonly IApiService _apiAction; //Create the API service process

    public Processor(IFileService fileServices, IApiService apiService)
    {
        //Get the services into the constructor
        _fileAction = fileServices;
        _apiAction = apiService;
    }

    public async Task RunAsync(string filePath, string outputPath)
    {
        var listUrl = await _fileAction.ReadWebUrl(filePath); //Creation of the list with the URLs
        List<WebData> infoWeb = [];

        foreach(string url in listUrl)
        {
            //Iteration url and create the WebData instance, after will be add in infoWeb list
            WebData webData = await _apiAction.GetWebDataAsync(url);
            Console.WriteLine($"Processing... {url}");
            infoWeb.Add(webData);
        }

        await _fileAction.WriteDataAsync(infoWeb, outputPath); //Cration of the .json Url Report
    }
}