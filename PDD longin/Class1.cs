using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDD_longin
{

    //如果好用，请收藏地址，帮忙分享。
    public class Render
    {
    }

    public class Update
    {
    }

    public class Unlike
    {
    }

    public class Services
    {
        /// <summary>
        /// 
        /// </summary>
        public Render render { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Update update { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Unlike unlike { get; set; }
    }

    public class TrackingContext
    {
        /// <summary>
        /// 
        /// </summary>
        public string sku_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string goods_id { get; set; }
    }

   

    public class ExtendMap
    {
        /// <summary>
        /// 
        /// </summary>
        public string create_order_token { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string create_order_msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string rank_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int page_from { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string create_order_check { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int original_front_env { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int current_front_env { get; set; }
    }

public class GroupStore
{
    /// <summary>
    /// 
    /// </summary>
    public string groupOrderId { get; set; }
}

public class GoodsItemStore
{
    /// <summary>
    /// 
    /// </summary>
    public int goodsNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isShowGoodsNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string showPlusMinusButton { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string increaseDisable { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int finalLimitNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int finalLeastNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string reduceDisable { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int limitStatus { get; set; }
}

public class VirtualAddressItemStore
{
    /// <summary>
    /// 
    /// </summary>
    public string mobileInputNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isFocused { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string showNativeMobileSelect { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string hasInitMobile { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> recordList { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string mobileNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string mobileOwner { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string disableRecList { get; set; }
}

public class StepInfoStore
{
    /// <summary>
    /// 
    /// </summary>
    public int depositPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string depositLeftTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string depositMiddleDesc { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string depositRightTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int inflatePrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int stepPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string stepLeftTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string stepMiddleDesc { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string stepRightTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int stepPayStartTime { get; set; }
}

public class AddressInfo
{
    /// <summary>
    /// 
    /// </summary>
    public string cantReceiveSupported { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string wechatFetchAvail { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int addressId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// 江西省
    /// </summary>
    public string province { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int provinceId { get; set; }
    /// <summary>
    /// 赣州市
    /// </summary>
    public string city { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int cityId { get; set; }
    /// <summary>
    /// 章贡区
    /// </summary>
    public string district { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int districtId { get; set; }
    /// <summary>
    /// 水东镇
    /// </summary>
    public string address { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string mobile { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isGoodsSoldHere { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> addressLabels { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> unpayAddressLabels { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string hasEditInRepay { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int addressGiftStatus { get; set; }
}

public class EditAddressStore
{
    /// <summary>
    /// 
    /// </summary>
    public string useAutoPopupTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string noAddressDialogTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string noAddressAutoPopup { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string showEditAddress { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isPayAddNewAddress { get; set; }
}

public class IdCardInfo
{
    /// <summary>
    /// 
    /// </summary>
    public string isIdCardInfoValidForMobileCard { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string idCardName { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string idCardNo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string snapshotId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string authTip { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string authMainTitleTip { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string authTipColor { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string authTitleTip { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string authNameTip { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string authIdTip { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string extendMap { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string sceneCode { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isPayAddNewIdCard { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string hideEditBtn { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string skipVerify { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string authTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string showIdCard { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string showIdCardHint { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string disableRecList { get; set; }
}



public class PayChannelListItem
{
    /// <summary>
    /// 
    /// </summary>
    public string channel { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int rank { get; set; }
    /// <summary>
    /// 微信支付
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public NameStyle nameStyle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string hint { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string hintIcon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public HintStyle hintStyle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int appId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string display { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string disabled { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string navToApp { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string recommend { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string signed { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string selected { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string defaultSelected { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string refresh { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string disableText { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string expanding { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int paymentType { get; set; }
}

public class NameStyle
{
    /// <summary>
    /// 
    /// </summary>
    public string fontColor { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int fontSize { get; set; }
}

public class HintStyle
{
    /// <summary>
    /// 
    /// </summary>
    public string fontColor { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int fontSize { get; set; }
}

public class PayMethodsItem
{
    /// <summary>
    /// 
    /// </summary>
    public string channel { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int rank { get; set; }
    /// <summary>
    /// 微信支付
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public NameStyle nameStyle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string hint { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string hintIcon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public HintStyle hintStyle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int appId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string display { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string disabled { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string navToApp { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string recommend { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string signed { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string selected { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string defaultSelected { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string refresh { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string disableText { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string expanding { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int paymentType { get; set; }
}

public class RetainWindowVo
{
    /// <summary>
    /// 
    /// </summary>
    public string displayType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string extendType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string contents { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> pictures { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int picWidth { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int picHeight { get; set; }
}

public class PaymentInfoStore
{
    /// <summary>
    /// 
    /// </summary>
    public string appPaymentEnv { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public IDictionary<string,string> appIdSet { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<PayChannelListItem> payChannelList { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string paymentNavToApp { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isHBEnvironment { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string canWechatDirectPay { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<PayMethodsItem> payMethods { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> installmentList { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int paymentType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string lockTerm { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int termIndex { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public RetainWindowVo retainWindowVo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string foldedSwitch { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string showRepayModifyPanel { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int repayModifyCountdown { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isDuoDuoPayAvailable { get; set; }
}

public class DeliveryInfoStore
{
    /// <summary>
    /// 
    /// </summary>
    public int srvShortTag { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string selectedServiceTransparentField { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int clickType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string displayContent { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string displayTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> templateList { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string showDeliveryList { get; set; }
}

public class ServerTimeStore
{
    /// <summary>
    /// 
    /// </summary>
    public int val { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string rc { get; set; }
}

public class CellBarStore
{
    /// <summary>
    /// 
    /// </summary>
    public string title { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string content { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string protocolUrl { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string protocolTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string richContents { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string protocolV2 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string unSelectedText { get; set; }
}

public class GreenShieldStore
{
    /// <summary>
    /// 
    /// </summary>
    public string piccImageUrl { get; set; }
}

public class ShipmentStripeStore
{
    /// <summary>
    /// 
    /// </summary>
    public string hasShipmentStripe { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string content { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string title { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int switchStatus { get; set; }
}

public class CouponMallStore
{
    /// <summary>
    /// 
    /// </summary>
    public string queryMallCoupon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int cellType { get; set; }
}

public class New_detailItem
{
    /// <summary>
    /// 正品(1654)
    /// </summary>
    public string text { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int icon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string font_color { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string background_color { get; set; }
}

public class Extend_map
{
    /// <summary>
    /// 
    /// </summary>
    public List<New_detailItem> new_detail { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> detail { get; set; }
}

public class ReturnDialogVo
{
    /// <summary>
    /// 
    /// </summary>
    public int dialog_type { get; set; }
    /// <summary>
    /// 确认要放弃付款吗？
    /// </summary>
    public string title { get; set; }
    /// <summary>
    /// 410821名用户好评过该商品
    /// </summary>
    public string content { get; set; }
    /// <summary>
    /// 暂时放弃
    /// </summary>
    public string left_button { get; set; }
    /// <summary>
    /// 继续支付
    /// </summary>
    public string right_button { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Extend_map extend_map { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int type { get; set; }
}

public class OrderInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int payPrice { get; set; }
    /// <summary>
    /// 实付款
    /// </summary>
    public string payTitle { get; set; }
    /// <summary>
    /// 免运费
    /// </summary>
    public string payContent { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string orderPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int couponPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string forceNewLine { get; set; }
}

public class XyhfOrderInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int payPrice { get; set; }
    /// <summary>
    /// 实付款
    /// </summary>
    public string payTitle { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string payContent { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int orderPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int couponPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string forceNewLine { get; set; }
}

public class PriceInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int orderPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int mallPromotionPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int platformPromotionPrice { get; set; }
}

public class SpecsItem
{
    /// <summary>
    /// 颜色分类
    /// </summary>
    public string spec_key { get; set; }
    /// <summary>
    /// 高帮大红
    /// </summary>
    public string spec_value { get; set; }
}

public class GoodsInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int number { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int price { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> goodsLabels { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string needId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string webpEnable { get; set; }
    /// <summary>
    /// 回力高低帮情侣帆布鞋韩版潮流板鞋学生女百搭2020年春季新款白鞋
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string beforeNameIcon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string beforeNameIconHeight { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string beforeNameIconWidth { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string allowedRegion { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string costProvinceCodes { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isCustoms { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int goodsType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int eventType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int mallId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int costTemplateId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int catId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int catId1 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int catId2 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int catId3 { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int catId4 { get; set; }
    /// <summary>
    /// 100%正品，假一赔十
    /// </summary>
    public string stockContent { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string stockColor { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string stockBackground { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int realNameAuth { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int goodsNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int isInstallment { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int groupId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int customerNum { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int buyLimit { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int startTime { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string thumbUrl { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<SpecsItem> specs { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> specifications { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int skuId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string normalPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string groupPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int weight { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string wareId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string activityId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int activityType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int unitPriceForCent { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string unitPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int quantity { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int limitStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int limitQuantity { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string limitMessage { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int leastQuantity { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int isDepositInflateGoods { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int isDepositOfHouse { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isSpikeGoods { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isCompensationGoods { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isDepositeGoods { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isMultiplyGoodsDiscount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isThreeForTwo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isVirtualGoods { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isMobile { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isGasNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isQQNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isPhoneNumCard { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string needAccount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string accountBits { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int overseaType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string massSubsidy { get; set; }
}

public class MallInfo
{
    /// <summary>
    /// 
    /// </summary>
    public int id { get; set; }
    /// <summary>
    /// 回力梦回专卖店
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string logo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string mallOrderPrice { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string canCompensate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> labels { get; set; }
}

public class ShippingInfo
{
    /// <summary>
    /// 
    /// </summary>
    public string title { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int cost { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string shippingPrice { get; set; }
}

public class MallCoupon
{
    /// <summary>
    /// 
    /// </summary>
    public string batchId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string couponId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string promotionUniqueNo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string shopPromotionVo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int promotionStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string discount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string displayType { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string displayName { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isReachMinAmount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string minAmount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string notUse { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string eventDiscount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string eventId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string promotionEventType { get; set; }
    /// <summary>
    /// 店铺优惠
    /// </summary>
    public string category { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string cellStyle { get; set; }
}

public class PlatformCoupon
{
    /// <summary>
    /// 
    /// </summary>
    public string batchId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string couponId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int promotionStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string discount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string displayType { get; set; }
    /// <summary>
    /// 百亿补贴已优惠24.9元
    /// </summary>
    public string displayName { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isReachMinAmount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string minAmount { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string notUse { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isSuperpositionCoupon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int superpositionCouponNumber { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isPlatformCouponForbidden { get; set; }
    /// <summary>
    /// 平台优惠
    /// </summary>
    public string category { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string cellStyle { get; set; }
}

public class PromotionInfo
{
    /// <summary>
    /// 
    /// </summary>
    public MallCoupon mallCoupon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public PlatformCoupon platformCoupon { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string depositCoupon { get; set; }
}

public class MallCouponList
{
    /// <summary>
    /// 
    /// </summary>
    public string hasMorePromotion { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> usableEvents { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> unUsableEvents { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> enableCoupons { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> disableCoupons { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> shopPromotions { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> unusableShopPromotions { get; set; }
}

public class PlatformCouponList
{
    /// <summary>
    /// 
    /// </summary>
    public List<string> enableCoupons { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public List<string> disableCoupons { get; set; }
}

public class RepeatedCoupon
{
}

public class ActivityParams
{
    /// <summary>
    /// 
    /// </summary>
    public int duoduo_type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int biz_type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string pid { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string cps_sign { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string out_group_order_id { get; set; }
}

public class Store
{
    /// <summary>
    /// 
    /// </summary>
    public string errorRedirectUrl { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isPre { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string shouldUseMockWhenPrepareClientData { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public Services services { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int frontEnv { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int pageFrom { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int frontVersion { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int isApp { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string goodsId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int groupId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string skuId { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int type { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isPay { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string orderServicePath { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string customMorganUrl { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string autoErrSamping { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public TrackingContext trackingContext { get; set; }

    public ExtendMap extendMap { get; set; }
    public string fastReturn { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string orderRefresh { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int orderNotModifyAddress { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string isWechatMiniProgram { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string cureNCov { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string addrGiftEntryStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int addressGiftStatus { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string chaosOrderSn { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string renderError { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string renderWarning { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string disableBackEvent { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public int morganDisableBackEvent { get; set; }
public GroupStore groupStore { get; set; }
/// <summary>
/// 
/// </summary>
public GoodsItemStore goodsItemStore { get; set; }
/// <summary>
/// 
/// </summary>
public VirtualAddressItemStore virtualAddressItemStore { get; set; }
/// <summary>
/// 
/// </summary>
public StepInfoStore stepInfoStore { get; set; }
/// <summary>
/// 
/// </summary>
public AddressInfo addressInfo { get; set; }
/// <summary>
/// 
/// </summary>
public EditAddressStore editAddressStore { get; set; }
/// <summary>
/// 
/// </summary>
public IdCardInfo idCardInfo { get; set; }

public PaymentInfoStore paymentInfoStore { get; set; }
/// <summary>
/// 
/// </summary>
public DeliveryInfoStore deliveryInfoStore { get; set; }
/// <summary>
/// 
/// </summary>
public ServerTimeStore serverTimeStore { get; set; }
/// <summary>
/// 
/// </summary>
public CellBarStore cellBarStore { get; set; }
/// <summary>
/// 
/// </summary>
public GreenShieldStore greenShieldStore { get; set; }
/// <summary>
/// 
/// </summary>
public ShipmentStripeStore shipmentStripeStore { get; set; }
/// <summary>
/// 
/// </summary>
public CouponMallStore couponMallStore { get; set; }
/// <summary>
/// 
/// </summary>
public string isServerRendered { get; set; }
/// <summary>
/// 
/// </summary>
public string isFinishInitLoading { get; set; }
/// <summary>
/// 
/// </summary>
public string isPreClientDataFetch { get; set; }
/// <summary>
/// 
/// </summary>
public string actionDisable { get; set; }
/// <summary>
/// 
/// </summary>
public string userActionDisable { get; set; }
/// <summary>
/// 
/// </summary>
public int unreachableRec { get; set; }
/// <summary>
/// 
/// </summary>
public int goodsNumber { get; set; }
/// <summary>
/// 
/// </summary>
public int orderAmount { get; set; }
/// <summary>
/// 
/// </summary>
public string isCouponToReceiving { get; set; }
/// <summary>
/// 
/// </summary>
public ReturnDialogVo returnDialogVo { get; set; }
/// <summary>
/// 
/// </summary>
public OrderInfo orderInfo { get; set; }
/// <summary>
/// 
/// </summary>
public XyhfOrderInfo xyhfOrderInfo { get; set; }
/// <summary>
/// 
/// </summary>
public PriceInfo priceInfo { get; set; }
/// <summary>
/// 
/// </summary>
public int btnStatus { get; set; }
/// <summary>
/// 
/// </summary>
public GoodsInfo goodsInfo { get; set; }
/// <summary>
/// 
/// </summary>
public MallInfo mallInfo { get; set; }
/// <summary>
/// 
/// </summary>
public List<string> payMethods { get; set; }
/// <summary>
/// 
/// </summary>
public ShippingInfo shippingInfo { get; set; }
/// <summary>
/// 
/// </summary>
public PromotionInfo promotionInfo { get; set; }
/// <summary>
/// 
/// </summary>
public List<string> receiveUsableEvents { get; set; }
/// <summary>
/// 
/// </summary>
public List<string> receiveUsableCoupons { get; set; }
/// <summary>
/// 
/// </summary>
public MallCouponList mallCouponList { get; set; }
/// <summary>
/// 
/// </summary>
public PlatformCouponList platformCouponList { get; set; }
/// <summary>
/// 
/// </summary>
public RepeatedCoupon repeatedCoupon { get; set; }
/// <summary>
/// 
/// </summary>
public string promotionEvent { get; set; }
/// <summary>
/// 
/// </summary>
public string showMorePlatformCoupon { get; set; }
/// <summary>
/// 
/// </summary>
public string showNoMoreHint { get; set; }
/// <summary>
/// 
/// </summary>
public int usePriority { get; set; }
/// <summary>
/// 
/// </summary>
public string disallowGoodsNumberChange { get; set; }
/// <summary>
/// 
/// </summary>
public string qiongqiVo { get; set; }
/// <summary>
/// 
/// </summary>
public ActivityParams activityParams { get; set; }
/// <summary>
/// 
/// </summary>
public string isWeChatPlatform { get; set; }
/// <summary>
/// 
/// </summary>
public string isNativePlatform { get; set; }
/// <summary>
/// 
/// </summary>
public string sourceChannel { get; set; }
}


    public class GoodsItem
    {

        public GoodsItem(Int64 _id, Int64 _number, string g_id)
        {
            sku_id = _id;
            sku_number = _number;
            goods_id = g_id;
        }
        /// <summary>
        /// 
        /// </summary>
        public Int64 sku_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Int64 sku_number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string goods_id { get; set; }
    }

    public class Order_Forms
    {
        /// <summary>
        /// 
        /// </summary>
        public int address_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<GoodsItem> goods { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string group_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string anti_content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int pay_app_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string is_app { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string page_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int page_from { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string activity_id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int duoduo_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int biz_type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ExtendMap attribute_fields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string source_channel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int source_type { get; set; }
    }
    class Order
    {
        public Store store { get; set; }
    }
}
