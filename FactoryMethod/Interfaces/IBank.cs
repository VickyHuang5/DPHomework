namespace FactoryMethod
{
    /// <summary>
    /// 銀行介面
    /// </summary>
    public interface IBank
    {
        /// <summary>
        /// 驗證卡號
        /// </summary>
        /// <param name="cardNumber">卡號</param>
        /// <returns>Boolean</returns>
        bool VerifyCardNumber(string cardNumber);
    }
}