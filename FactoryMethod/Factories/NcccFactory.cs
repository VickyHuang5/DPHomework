namespace FactoryMethod
{
    /// <summary>
    /// 信用卡聯合處理中心工廠
    /// </summary>
    public class NcccFactory : IBankFactory
    {
        /// <summary>
        /// 驗證信用卡
        /// </summary>
        /// <returns>信用卡聯合處理中心</returns>
        public IBank VerifyCreditCard()
        {
            return new Nccc();
        }
    }
}