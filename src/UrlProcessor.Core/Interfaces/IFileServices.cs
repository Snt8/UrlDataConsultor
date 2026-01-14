using UrlProcessor.Core.Model;

interface IFileService
{
    Task<List<string>> ReadWebUrl(string filePath);
    //Method for read the file, and get the URL

    Task WriteDataAsync(List<WebData> outputPath);
    //Method for write the data of the server given for the API
}