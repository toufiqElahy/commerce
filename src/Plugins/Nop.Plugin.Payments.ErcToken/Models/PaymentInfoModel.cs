using Nop.Web.Framework.Models;

namespace Nop.Plugin.Payments.ErcToken.Models
{
    public class PaymentInfoModel : BaseNopModel
    {
        public string DescriptionText { get; set; }


        public string Code { get; set; }
        public string ImgUrl { get; set; }
        public string CoinName { get; set; }
    }
}