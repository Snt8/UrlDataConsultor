namespace UrlProcessor.Core.Interface;
using UrlProcessor.Core.Model;

public interface IFileService
{
    public Task<List<string>> ReadWebUrl(string filePath);
    //Method for read the file, and get the URL

    public Task WriteDataAsync(List<WebData> outputPath);
    //Method for write the data of the server given for the API
}