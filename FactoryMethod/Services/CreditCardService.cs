using FactoryMethod.Models;

namespace FactoryMethod.Services
{
    /// <summary>
    /// 信用卡服務
    /// </summary>
    public class CreditCardService
    {
        /// <summary>
        /// 是否驗證成功
        /// </summary>
        /// <param name="cardData">信用卡資料</param>
        /// <returns>Boolean</returns>
        public bool IsVerified(CreditCardViewModel cardData)
        {
            IBankFactory bankFactory = null;
            if (cardData.BankName == "Cathay")
            {
                bankFactory = new CathayBankFactory();
            }
            else if (cardData.BankName == "CTBC")
            {
                bankFactory = new CtbcBankFactory();
            }
            else if (cardData.BankName == "NCCC")
            {
                bankFactory = new NcccFactory();
            }

            IBank bank = bankFactory.VerifyCreditCard();
            return bank.VerifyCardNumber(cardData.CardNumber);
        }
    }
}