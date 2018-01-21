namespace AbstractFactory
{
    /// <summary>
    /// 魔獸爭霸靴子
    /// </summary>
    public class WarcraftBoots : AbstractBoots
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public WarcraftBoots(string roleName) : base(roleName)
        {
        }
    }
}