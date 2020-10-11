using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JavaScriptEngineSwitcher;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using Flurl;
using Flurl.Http;
using System.Net;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace PDD_longin
{


 
    class Program
    {
        async static Task testAsync()
        {
            var pdd = new PDDApi();
            await  pdd.GetPhoneKeyAsync("15970792290");
            var code = "123";
            await pdd.loginAsync(code);

            Console.WriteLine(pdd.token.ToString());

            pdd.Save();
            var a = await pdd.QueryOrderListAsync(QueryOrderType.all);

            Console.WriteLine(a);




        }
        static void Main(string[] args)
        {

        }
    }
}
