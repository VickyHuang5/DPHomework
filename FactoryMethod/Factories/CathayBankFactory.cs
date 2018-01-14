namespace FactoryMethod
{
    /// <summary>
    /// 國泰世華銀行工廠
    /// </summary>
    public class CathayBankFactory : IBankFactory
    {
        /// <summary>
        /// 驗證信用卡
        /// </summary>
        /// <returns>國泰世華銀行</returns>
        public IBank VerifyCreditCard()
        {
            return new CathayBank();
        }
    }
}