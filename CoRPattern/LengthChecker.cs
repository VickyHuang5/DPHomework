namespace CoRPattern
{
    /// <summary>
    /// 長度檢查器
    /// </summary>
    public class LengthChecker : AbstractChecker
    {
        /// <summary>
        /// 覆寫檢查
        /// </summary>
        /// <param name="idNumber">身份證號</param>
        /// <returns>檢查結果boolean</returns>
        public override bool Check(string idNumber)
        {
            if (!(idNumber.Length == 10))
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