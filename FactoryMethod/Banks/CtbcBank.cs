namespace FactoryMethod
{
    /// <summary>
    /// 中國信託銀行
    /// </summary>
    public class CtbcBank : IBank
    {
        /// <summary>
        /// 驗證卡號
        /// </summary>
        /// <param name="cardNumber">卡號</param>
        /// <returns>Boolean</returns>
        public bool VerifyCardNumber(string cardNumber)
        {
            return cardNumber == "4003610000007890";
        }
    }
}