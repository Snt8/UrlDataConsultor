namespace UrlProcessor.App.Services;
using UrlProcessor.Core.Interface;
using UrlProcessor.Core.Model;
using System.IO;
using System.ComponentModel;
using System.Linq;

public class FileServices : IFileService
{
    public async Task<List<string>> ReadWebUrl(string filePath)
    {
        if(!File.Exists(filePath)) return new List<string>();
        var lecturaDatos = await File.ReadAllLinesAsync(filePath);
        return lecturaDatos.ToList();
    }

    public Task WriteDataAsync(List<WebData> outputPath)
    {
        throw new NotImplementedException();
    }
}
