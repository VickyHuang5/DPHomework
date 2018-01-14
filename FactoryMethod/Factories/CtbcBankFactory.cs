namespace FactoryMethod
{
    /// <summary>
    /// 中國信託銀行工廠
    /// </summary>
    public class CtbcBankFactory : IBankFactory
    {
        /// <summary>
        /// 驗證信用卡
        /// </summary>
        /// <returns>中國信託銀行</returns>
        public IBank VerifyCreditCard()
        {
            return new CathayBank();
        }
    }
}