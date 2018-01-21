namespace AbstractFactory
{
    /// <summary>
    /// 寶可夢盔甲
    /// </summary>
    public class PokemonArmor : AbstractArmor
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public PokemonArmor(string roleName) : base(roleName)
        {
        }
    }
}