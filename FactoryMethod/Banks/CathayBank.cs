namespace FactoryMethod
{
    /// <summary>
    /// 國泰世華銀行
    /// </summary>
    public class CathayBank : IBank
    {
        /// <summary>
        /// 驗證卡號
        /// </summary>
        /// <param name="cardNumber">卡號</param>
        /// <returns>Boolean</returns>
        public bool VerifyCardNumber(string cardNumber)
        {
            return cardNumber == "4563110000001234";
        }
    }
}