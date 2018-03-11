namespace CoRPattern
{
    /// <summary>
    /// 抽象檢查器
    /// </summary>
    public abstract class AbstractChecker : IChecker
    {
        /// <summary>
        /// 檢查器
        /// </summary>
        protected IChecker nextChecker;

        /// <summary>
        /// 檢查
        /// </summary>
        /// <param name="idNumber">身份證號</param>
        /// <returns>檢查結果boolean</returns>
        public abstract bool Check(string idNumber);

        /// <summary>
        /// 設定後置檢查器
        /// </summary>
        /// <param name="checker">後置檢查器</param>
        /// <returns>設定後的檢查器</returns>
        public IChecker SetNextChecker(IChecker checker)
        {
            return this.nextChecker = checker;
        }
    }
}