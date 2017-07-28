using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTW;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;

namespace ConsoleApplication10
{
    class Program
    {   
        const decimal CONVERSIONRATE = 1.5M;
        private static readonly string SterlingJsonFile = string.Format("{0}\\Sterling.json", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        private static readonly string EuroJsonFile = string.Format("{0}\\Euro.json", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        static void Main(string[] args)
        {
        var tableASterlingData = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(SterlingJsonFile));
        var tableBEuroData     = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(EuroJsonFile));
        }
    }
}   
