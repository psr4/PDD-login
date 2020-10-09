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

namespace PDD_longin
{


    public class UserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int uid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string access_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string acid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string uin { get; set; }
    }
    public class ServerTime
    {
        public string server_time { get; set; }
        
    }
    class Program
    {
        static IJsEngine jsEngine = new V8JsEngine();
        static string Get_nano_fp()
        {

            using (IJsEngine jsEngine = new V8JsEngine())
            {
                jsEngine.ExecuteFile(@"C:\Users\Yun\Desktop\cnm.js");
               return  (string)jsEngine.CallFunction("create_nano_fp");
            }
        }
        static async void sb(string phone)
        {
            using (var cli = new FlurlClient("http://yangkeduo.com/").EnableCookies())
            {
                var _nano_fp = Get_nano_fp();

                cli.WithHeader("Accept", "application/json, text/plain, */*");
                cli.WithHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36 Edg/85.0.564.68");

                await cli.Request().GetAsync();



                cli.Cookies.Add(
                "ua",
                 new Cookie("ua",
                 @"Mozilla%2F5.0%20(Windows%20NT%2010.0%3B%20
                                Win64%3B%20x64)%20AppleWebKit%2F537.36%20(KH
                                TML%2C%20like%20Gecko)%20Chrome%2F85.0.4183.1
                                21%20Safari%2F537.36%20Edg%2F85.0.564.68"));
                  cli.Cookies.Add(
                        "_nano_fp",
                        new Cookie("_nano_fp", _nano_fp));
               var dm= await cli.Request("proxy/api/api/server/_stm?pdduid=0").GetJsonAsync<ServerTime>();
                var api_uid = cli.Cookies["api_uid"].Value;
                await cli.Request("proxy/api/api/sigerus/mobile/code/request?pdduid=0").
                     PostJsonAsync(new
                     {
                         platform = 4,
                         fingerprint = "{}",
                         touchevent = "{}",
                         mobile = phone,
                         screen_token = jsEngine.CallFunction("get_anti_content", "code - button", "http://mobile.yangkeduo.com/login.html", _nano_fp, api_uid, dm.server_time)// GetScreentoken(_nano_fp, api_uid, dm.server_time)
            });


                
                var key = Console.ReadLine();







                var r = await cli.Request("proxy/api/api/sigerus/login_mobile?pdduid=0").
                    PostJsonAsync(new
                    {
                        mobile = phone,
                        code = key,
                        anti_content = jsEngine.CallFunction("get_anti_content", "submit-button", "http://mobile.yangkeduo.com/login.html?page_id=0&is_back=1", _nano_fp, api_uid, dm.server_time)

                    });
                var text = await r.Content.ReadAsStringAsync();
                Console.WriteLine(text);




            }

        }
        static void Main(string[] args)
        {
            jsEngine.ExecuteFile(@"C:\Users\Yun\Desktop\cnm.js");

            sb("15970896621");
            Console.ReadKey();

        }
    }
}
