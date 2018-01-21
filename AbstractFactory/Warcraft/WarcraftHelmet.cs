namespace AbstractFactory
{
    /// <summary>
    /// 魔獸爭霸頭盔
    /// </summary>
    public class WarcraftHelmet : AbstractHelmet
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public WarcraftHelmet(string roleName) : base(roleName)
        {
        }
    }
}