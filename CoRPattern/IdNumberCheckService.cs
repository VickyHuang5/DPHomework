namespace CoRPattern
{
    /// <summary>
    /// 身分證號檢查服務
    /// </summary>
    public class IdNumberCheckService
    {
        /// <summary>
        /// 檢查身分證號
        /// </summary>
        /// <param name="idNumber">身分證號</param>
        /// <returns>檢查結果boolean</returns>
        public bool CheckIdNumber(string idNumber)
        {
            IChecker Checker = new FirstLetterChecker();
             Checker.SetNextChecker(new LengthChecker())
                    .SetNextChecker(new ValidIdChecker());
            return Checker.Check(idNumber);
        }
    }
}