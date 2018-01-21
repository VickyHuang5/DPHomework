namespace AbstractFactory
{
    /// <summary>
    /// 寶可夢靴子
    /// </summary>
    public class PokemonBoots : AbstractBoots
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public PokemonBoots(string roleName) : base(roleName)
        {
        }
    }
}