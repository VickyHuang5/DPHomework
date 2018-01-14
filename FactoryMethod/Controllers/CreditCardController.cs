using FactoryMethod.Models;
using FactoryMethod.Services;
using Microsoft.AspNetCore.Mvc;

namespace FactoryMethod.Controllers
{
    /// <summary>
    /// 信用卡API
    /// </summary>
    [Route("api/[controller]")]
    public class CreditCardController : Controller
    {
        /// <summary>
        /// 驗證信用卡
        /// </summary>
        /// <param name="cardData">信用卡資料</param>
        /// <returns>驗證結果</returns>
        [HttpPost]
        [Route("verify")]
        public string VerifyCreditCard([FromBody]CreditCardViewModel cardData)
        {
            string verifiedResult = string.Empty;
            CreditCardService service = new CreditCardService();
            if (service.IsVerified(cardData))
            {
                verifiedResult = "授權成功";
            }
            else
            {
                verifiedResult = "授權失敗";
            }

            return verifiedResult;
        }
    }
}