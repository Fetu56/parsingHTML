using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace HtmlPar
{
    static class GisMeteo
    {
        static public string id = "4368";
        static private string url = "https://www.gismeteo.com/";
        static private HtmlWeb web = new HtmlWeb();
        static public HtmlNode UpdateNode()
        {
            var web_cookies = new CookieContainer();
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("https://www.gismeteo.com/");
            web_cookies.SetCookies(new Uri("https://www.gismeteo.com/"), $"cityUS={id}");
            myWebRequest.CookieContainer = web_cookies;
            HttpWebResponse responce = (HttpWebResponse)myWebRequest.GetResponse();
            var doc = new HtmlDocument();
            using (StreamReader stream = new StreamReader(
        responce.GetResponseStream(), Encoding.UTF8))
            {
                doc.LoadHtml(stream.ReadToEnd());
            }
            
            return doc.DocumentNode;
        }
    }
}
