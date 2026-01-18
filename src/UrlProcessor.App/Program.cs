using UrlProcessor.App;
using UrlProcessor.App.Services;

public class Program
{
    public static async Task Main(string[] args)
    {
        HttpClient httpClient = new HttpClient();
        FileService fileService = new FileService();
        ApiService apiService = new ApiService(httpClient);
        Processor processor = new Processor(fileService, apiService);

        string filePath = "test.txt";
        string outputPath = "report.json";


        try
        {
            Console.WriteLine("Starting the process...");
            await processor.RunAsync(filePath, outputPath);
            Console.WriteLine($"Process Useful, you can to see the report in {outputPath}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"The procces has failure {ex}");
        }
    }
}