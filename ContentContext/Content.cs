using Balta.SharedContext;

namespace Balta.ContentContext 
{
 public abstract class Content : Base
 {
    public Content(string title, string url) 
    {
      Title = title;
      Url = url;
    } 

    public string Title {get; set;}

    public string Url {get; set; }
 }   
}

//Guid é um global unique 
//SPOF ponto unico de falha
// abstract -> nunca vou conseguir instanciar essa classe, ela é abstrata