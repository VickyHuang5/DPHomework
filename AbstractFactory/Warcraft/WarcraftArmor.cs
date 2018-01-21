namespace AbstractFactory
{
    /// <summary>
    /// 魔獸爭霸盔甲
    /// </summary>
    public class WarcraftArmor : AbstractArmor
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public WarcraftArmor(string roleName) : base(roleName)
        {
        }
    }
}