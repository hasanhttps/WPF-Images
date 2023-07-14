using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Research_Practise.Models;
using static WPF_Research_Practise.Commands.JsonHandling;


namespace WPF_Research_Practise
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ReadData<List<Galery>>("images");
        }
    }
}
