namespace FactoryMethod
{
    /// <summary>
    /// 信用卡聯合處理中心
    /// </summary>
    public class Nccc : IBank
    {
        /// <summary>
        /// 驗證卡號
        /// </summary>
        /// <param name="cardNumber">卡號</param>
        /// <returns>Boolean</returns>
        public bool VerifyCardNumber(string cardNumber)
        {
            return cardNumber == "552003000005678";
        }
    }
}