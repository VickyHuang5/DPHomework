namespace AbstractFactory
{
    /// <summary>
    /// 寶可夢武器
    /// </summary>
    public class PokemonWeapon : AbstractWeapon
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public PokemonWeapon(string roleName) : base(roleName)
        {
        }
    }
}