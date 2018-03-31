using System;
using crawler;
using System.Net.Http;
using HtmlAgilityPack;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using crawler.Models;

namespace crawlingtest
{
    class Program
    {
        static void Main(string[] args)
        {
            CrawlAgent datawrawler = new CrawlAgent();
            var  item= datawrawler.Gethtml();
            foreach (var data in item) {
                Console.WriteLine(data.programme_name);
            }
            Console.ReadKey();
        }
      
    }

}
