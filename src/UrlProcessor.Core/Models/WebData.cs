namespace UrlProcessor.Core.Model;

public class WebData
{
    //Class that contains the informations that we consult in the Web Site
    public string Url {get; init;} = string.Empty;
    public string Name {get; set;} = string.Empty;
    public DateTime TimeDate {get; init;}
    public TimeSpan TimeSpan {get; init;}
    public int StatusCode {get; set;}
    public string ErrorException {get; init;} = string.Empty;
    public bool Exito {get; init;}
    
}