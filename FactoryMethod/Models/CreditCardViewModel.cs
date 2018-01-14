namespace FactoryMethod.Models
{
    /// <summary>
    /// 信用卡資訊
    /// </summary>
    public class CreditCardViewModel
    {
        /// <summary>
        /// 發卡行
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// 信用卡號
        /// </summary>
        public string CardNumber { get; set; }
    }
}