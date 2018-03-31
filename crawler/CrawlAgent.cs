using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Linq;
using crawler.Models;

namespace crawler
{
    public class CrawlAgent
    {
        public CrawlAgent() { }

        public  List<AcProgrammes> Gethtml()
        {

            var webget = new HtmlWeb();
            var otrhtml = webget.Load("https://fskm.uitm.edu.my/v4/index.php/2015-05-21-01-12-29/2015-05-21-01-19-14");
            var item = otrhtml.DocumentNode.SelectNodes("//div[@itemprop='articleBody']/ul/li").ToArray();
            List<AcProgrammes> aclist = new List<AcProgrammes>();
            var obj = new AcProgrammes();
            foreach (var data in item)
            {
                string name = data.InnerText;
                string code =data.InnerText.Substring(data.InnerText.IndexOf("-") + 1);
                string link = "https://fskm.uitm.edu.my" + data.FirstChild.Attributes["href"].Value;
                aclist.Add(new AcProgrammes(name,code,link));
            }

            return aclist;

        }

    }
}
