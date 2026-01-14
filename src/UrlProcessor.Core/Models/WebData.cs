namespace UrlProcessor.Core.Model;

public class WebData
{
    //Class that contains the informations that we consult in the Web Site
    public string Url {get; private set;}
    public string Name {get; set;} = string.Empty;
    public DateTime TimeDate {get; set;}
    public TimeSpan TimeSpan {get; set;}
    public int ErrorCode {get; set;}
    public string ErrorException {get; set;} = string.Empty;
    public bool Exito {get; set;}

    public WebData (string objUrl)
    {
        Url = objUrl;
    }
    
}