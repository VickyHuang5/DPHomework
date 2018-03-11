using System.Text;

namespace CoRPattern
{
    /// <summary>
    /// 第一個字母檢查器
    /// </summary>
    public class FirstLetterChecker : AbstractChecker
    {
        /// <summary>
        /// 覆寫檢查
        /// </summary>
        /// <param name="idNumber">身份證號</param>
        /// <returns>檢查結果boolean</returns>
        public override bool Check(string idNumber)
        {
            int firstLetter = Encoding.ASCII.GetBytes(idNumber.ToUpper())[0];
            if (!(firstLetter >= 65 && firstLetter <= 90))
            {
                return false;
            }

            if (this.nextChecker == null)
            {
                return true;
            }

            return this.nextChecker.Check(idNumber);
        }
    }
}