namespace AbstractFactory
{
    /// <summary>
    /// 魔獸爭霸帽子
    /// </summary>
    public class WarcraftHat : AbstractHat
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public WarcraftHat(string roleName) : base(roleName)
        {
        }
    }
}