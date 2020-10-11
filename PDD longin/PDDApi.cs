using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using Flurl;
using Flurl.Http;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.CompilerServices;

namespace PDD_longin
{
    public class UserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public UInt64 uid { get; set; }
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
        public override string ToString()
        {
            string r = "";
            
            return string.Format("{0} = {1} \r\n{2} = {3} \r\n{4} = {5} \r\n{6} = {7} \r\n",
                uid.ToString(), uid,
                access_token.ToString(), access_token,
                acid.ToString(), acid,
                uin.ToString(), uin);
        }

    }
    public class ServerTime
    {
        public string server_time { get; set; }

    }
    public enum QueryOrderType
    {
                
         all    ,       // 全部
         unpaidV2  ,    // 待付款
         grouping  ,    // 待分享
         unshipping ,   // 待发货
         unreceived,    // 待收货
         unrated        // 待评价
    }

    public class Order_goodsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string goods_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string sku_id { get; set; }
        /// <summary>
        /// 垃圾袋加厚黑色家用厨房家用办公中号背心式日常塑料袋手提式批发
        /// </summary>
        public string goods_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int goods_price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int goods_number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string thumb_url { get; set; }
        /// <summary>
        /// 加厚款（80%家庭选择）,50个垃圾袋
        /// </summary>
        public string spec { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int event_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int is_pre_sale { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int goods_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cat_id_1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cat_id_2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cat_id_3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int cat_id_4 { get; set; }
    }

    public class Group_order
    {
        /// <summary>
        /// 
        /// </summary>
        public int group_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int customer_num { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int expire_time { get; set; }
    }

    public class Mall
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string logo { get; set; }
        /// <summary>
        /// 胜韧
        /// </summary>
        public string mall_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string mall_url { get; set; }
    }

    public class Type_value
    {
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }
    }

    public class Style
    {
        /// <summary>
        /// 
        /// </summary>
        public int color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int click_type { get; set; }
    }

    public class Order_buttonsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Type_value type_value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Style style { get; set; }
        /// <summary>
        /// 再次购买
        /// </summary>
        public string brief_prompt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string support_version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string metric_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
    }

    public class Confirm_receipt
    {
        /// <summary>
        /// 为保障您的售后权益，请收到货确认无误后，再确认收货哦！
        /// </summary>
        public string message { get; set; }
    }

    public class Alert_info
    {
        /// <summary>
        /// 
        /// </summary>
        public Confirm_receipt confirm_receipt { get; set; }
    }

    public class OrdersItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string group_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string group_order_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string address_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string shipping_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string order_sn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string parent_order_sn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int order_amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int shipping_amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int discount_amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int service_amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int display_amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string used_coupons { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int biz_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int group_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int order_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pay_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int shipping_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comment_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int combined_order_status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int shipping_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int order_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int receive_time { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tracking_number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string order_link_url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Order_goodsItem> order_goods { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Group_order group_order { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Mall mall { get; set; }
        /// <summary>
        /// {"prefix":"实付:","suffix":"(免运费)","suffixStyle":0,"prefixStyle":0,"hidePrice":false,"prefixV2":null,"suffixFold":false,"extraInfo":null}
        /// </summary>
        public string price_desc { get; set; }
        /// <summary>
        /// 交易已取消
        /// </summary>
        public string order_status_prompt { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int activity_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_super_group { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> tabs_belong { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> goods_tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> order_tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Order_buttonsItem> order_buttons { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Alert_info alert_info { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string fp_id { get; set; }
    }

    public class OrdersInfo
    {
  
        public int server_time { get; set; }

        public List<OrdersItem> orders { get; set; }

    }

    public class  Config
    {
        public Config(IDictionary<string, Cookie> ck, UserInfo tk)
        {
            cookie = ck;
            token = tk;
        }
        public IDictionary<string, Cookie>  cookie { get; set; }

        public UserInfo token { get; set; }
    }

















    class PDDApi
    {
        FlurlClient Session = new FlurlClient("http://mobile.yangkeduo.com/").EnableCookies();
        IJsEngine jsEngine = new V8JsEngine();
        string _nano_fp = "";

        string phone = "";

        string api_uid = "";
        string server_time = "";

        public UserInfo token = new UserInfo();

        public  PDDApi()
        {
            jsEngine.ExecuteFile(@"../../jm.js");
            _nano_fp = (string)jsEngine.CallFunction("create_nano_fp");
            Session.WithHeader("Accept", "application/json, text/plain, */*");
            Session.WithHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36 Edg/85.0.564.68");
            Session.Cookies.Add(
               "ua",
                new Cookie("ua",
                @"Mozilla%2F5.0%20(Windows%20NT%2010.0%3B%20
                                Win64%3B%20x64)%20AppleWebKit%2F537.36%20(KH
                                TML%2C%20like%20Gecko)%20Chrome%2F85.0.4183.1
                                21%20Safari%2F537.36%20Edg%2F85.0.564.68"));
            Session.Cookies.Add(
                  "_nano_fp",
                  new Cookie("_nano_fp", _nano_fp));


            
        }
        ~PDDApi()
        {

        }
        public async Task<bool> GetPhoneKeyAsync(string _phone)
        {
            try
            {
                if (_phone == null) return false;
                phone = _phone;
                await Session.Request().GetAsync();


                server_time = (await Session.Request("proxy/api/api/server/_stm?pdduid=0").GetJsonAsync<ServerTime>()).server_time;
                api_uid = Session.Cookies["api_uid"].Value;




                var r = await Session.Request("proxy/api/api/sigerus/mobile/code/request?pdduid=0").
                       PostJsonAsync(new
                       {
                           platform = 4,
                           fingerprint = "{}",
                           touchevent = "{}",
                           mobile = phone,
                           screen_token = jsEngine.CallFunction("get_anti_content", "code - button", "http://mobile.yangkeduo.com/login.html", _nano_fp, api_uid, server_time)// GetScreentoken(_nano_fp, api_uid, dm.server_time)
                   });
                return (await r.Content.ReadAsStringAsync()).Equals("{}");
            }
            catch (Exception)
            {

                return false ;
            }


        }
        public async Task<bool> loginAsync(string code)
        {
            var r = await Session.Request("proxy/api/api/sigerus/login_mobile?pdduid=0").
            PostJsonAsync(new
            {
                mobile = phone,
                code = code,
                anti_content = jsEngine.CallFunction("get_anti_content", "submit-button", "http://mobile.yangkeduo.com/login.html?page_id=0&is_back=1", _nano_fp, api_uid, server_time)

            });

            token = JsonConvert.DeserializeObject<UserInfo>(await r.Content.ReadAsStringAsync());
            return token.uid != 0;
        }

        public async Task<string> QueryOrderListAsync(QueryOrderType Type)
        {
            List<string> channel_list = new List<string>( { "9", "30", "31", "35", "38", "52", "97", "122", "135", "322", " - 1" });
            var r = await Session.Request(string.Format("proxy/api/api/aristotle/order_list?pdduid={0}", token.uid))
                .PostJsonAsync(
                new
                {
                    timeout = 1300,
                    type = Type.ToString(),
                    page = 1,
                    origin_host_name = "mobile.yangkeduo.com",
                    pay_channel_list = channel_list,
                    size = 10
                });
            return await r.Content.ReadAsStringAsync();
        }
        public async Task<string> Order(string _rank_id ,string sku_id,string group_id, string goods_id, string goods_number, string page_from ,string refer_page_id ,string refer_page_sn)
        {

            var url = string.Format(@"_oc_rank_id={0}&sku_id={1}&group_id={2}&goods_id={3}
                                                                    &goods_number={4}&page_from={5}&refer_page_element=open_btn&source_channel=0
                                                                    &refer_page_name=goods_detail&refer_page_id={6}&refer_page_sn={7}",
                                                                    _rank_id, sku_id, group_id, goods_id, goods_number, page_from, refer_page_id, refer_page_sn);
            var Store =( await Session.Request(url).GetJsonAsync<Order>()).store;
            var post = new Order_Forms();
            post.activity_id = Store.goodsInfo.activityId; 
            post.anti_content =(string) jsEngine.CallFunction("get_anti_content", "submit-button", "http://mobile.yangkeduo.com/" + url, _nano_fp, api_uid, server_time);
            post.attribute_fields = Store.extendMap;
            post.goods = new List<GoodsItem>();
            post.goods.Add(new GoodsItem(Convert.ToInt64(Store.skuId),1,Store.goodsId));
            post.group_id = Convert.ToString(Store.groupId);
            post. page_from = Convert.ToInt32(page_from);
            post.page_id = refer_page_id;
            post.pay_app_id = 9;
            post.version = 1;
             return await Session.Request(string.Format("proxy/api/order?pdduid={0}", token.uid)).PostJsonAsync(post).ReceiveString();


            /*
             
            支付
            http://yangkeduo.com/proxy/api/order/prepay?pdduid=4833122078772
             {"pay_app_id":9,"version":3,"attribute_fields":{"paid_times":0,"forbid_contractcode":"1","forbid_pappay":"1"},"return_url":"http://yangkeduo.com/transac_wappay_callback.html?order_sn=201010-581265163400052&order_amount=59900&goods_id=19317497306","order_sn":"201010-581265163400052","term":null}
             
             
             
             
             */












        }
        public void Load()
        {
            var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
            token = config.token;

            Session.WithCookies (config.cookie);
        }
        public void Save()
        {
           var s = JsonConvert.SerializeObject(new Config(Session.Cookies, token));

            File.WriteAllText("config.json", s);

        }
        static async Task<string> QueryOrderListForTokenAsync()
        {
            return "";
        }

    }
}
