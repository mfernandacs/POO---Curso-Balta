using System;
using Balta.ContentContext;
using Balta.SubscriptionContext;
using Balta.NotificationContext;


namespace Balta 
{

    class Program 
    {
        static void Main (string[] args)
        {
           var articles = new List<Article>();
           articles.Add(new Article("Artigo sobre OPP", "orintacao-objetos")); 
           articles.Add(new Article("Artigo sobre C#", "csharp")); 
           articles.Add(new Article("Artigo sobre .Net", "dotnet")); 

           foreach(var article in articles)
           {
               Console.WriteLine(article.Id);
               Console.WriteLine(article.Title);
               Console.WriteLine(article.Url);
           }

           var courses = new List<Course>();
           var courseOOP = new Course("Fundamentos OOP","fundamentos-oop"); 
           var courseCSHARP = new Course("Fundamentos C#","fundamentos-csharp");
           var courseASPNET = new Course("Fundamentos ASP.NET","fundamentos-aspnet ");

           courses.Add(courseOOP);
           courses.Add(courseCSHARP);
           courses.Add(courseASPNET);


           var careers = new List<Career>();
           var careerDotnet = new Career("Especialista .NET","especialista=dotnet");
           var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
           var careerItem = new CareerItem(1, "Comece por aqui", "", courseCSHARP);
           var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseASPNET);
           careerDotnet.Items.Add(careerItem2 );
           careerDotnet.Items.Add(careerItem);
           careerDotnet.Items.Add(careerItem3 );
           careers.Add(careerDotnet);

           foreach(var career in careers)
           {
               Console.WriteLine(career.Title);
               foreach(var item in career.Items.OrderBy(x => x.Order)){
                   Console.WriteLine($"{item.Order} - {item.Title}");
                   Console.WriteLine(item.Course.Level);
               }
           }

           var payPalSubscription = new PayPalSubscription();
           var student = new Student();
           student.CreateSubscription(payPalSubscription);
        }
    }
}