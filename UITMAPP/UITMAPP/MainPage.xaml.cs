using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using crawler.Models;
using crawler;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

namespace UITMAPP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
      
        public MainPage()
        {
             
            InitializeComponent();
            List<AcProgrammes> list = new List<AcProgrammes>();
            list = GetProgramme();
            BindingContext = list;

        }
        public static List<AcProgrammes> GetProgramme() {
            List<AcProgrammes> thel = new List<AcProgrammes>();
            CrawlAgent agent = new CrawlAgent();
            var item = agent.Gethtml();
            foreach (var data in item) {
                thel.Add(data);

            }
            return thel;
        }
	}
}