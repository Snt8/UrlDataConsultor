using UrlProcessor.Core.Model;

interface IFileServices
{
    Task<List<string>> ReadWebUrl(string directions);
    //Method for read the file, and get the URL

    Task WriteDataAsync(List<WebData> webInfo);
    //Method for write the data of the server given for the API
}