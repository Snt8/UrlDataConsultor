namespace UrlProcessor.App.Services;
using UrlProcessor.Core.Interface;
using UrlProcessor.Core.Model;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Runtime.CompilerServices;

public class FileService : IFileService
{
    public async Task<List<string>> ReadWebUrl(string filePath)
    {
        if(!File.Exists(filePath)) return new List<string>();
        //Check if the file exist, if not we return a empty List
        var lecturaDatos = await File.ReadAllLinesAsync(filePath);
        //Return the Lists with the URLs
        return lecturaDatos.ToList();
    }

    public async Task WriteDataAsync(List<WebData> data, string filePath)
    {
        var opciones = new JsonSerializerOptions {WriteIndented = true};
        try
        {
            string? pathDirection = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(pathDirection))
            {
                Directory.CreateDirectory(pathDirection);
            }
            string jsonUrl = JsonSerializer.Serialize(data, opciones);
            await File.WriteAllTextAsync(filePath, jsonUrl);
        }

        catch (Exception ex)
        {
            throw new Exception($"Failure in the creation of the .json {ex}");
        }
    }
}
