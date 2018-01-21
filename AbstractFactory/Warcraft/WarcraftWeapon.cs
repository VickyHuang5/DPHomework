namespace AbstractFactory
{
    /// <summary>
    /// 魔獸爭霸武器
    /// </summary>
    public class WarcraftWeapon : AbstractWeapon
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public WarcraftWeapon(string roleName) : base(roleName)
        {
        }
    }
}