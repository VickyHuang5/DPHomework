namespace CoRPattern
{
    /// <summary>
    /// 檢查器介面
    /// </summary>
    public interface IChecker
    {
        /// <summary>
        /// 檢查
        /// </summary>
        /// <param name="idNumber">身份證號</param>
        /// <returns>檢查結果boolean</returns>
        bool Check(string idNumber);

        /// <summary>
        /// 設定後置檢查器
        /// </summary>
        /// <param name="checker">後置檢查器</param>
        /// <returns>設定後的檢查器</returns>
        IChecker SetNextChecker(IChecker checker);
    }
}