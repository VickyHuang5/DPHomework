using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 銀行介面
    /// </summary>
    public interface IBankFactory
    {
        /// <summary>
        /// 驗證信用卡
        /// </summary>
        /// <returns>銀行</returns>
        IBank VerifyCreditCard();
    }
}
