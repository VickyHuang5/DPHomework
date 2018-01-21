namespace AbstractFactory
{
    /// <summary>
    /// 寶可夢帽子
    /// </summary>
    public class PokemonHat : AbstractHat
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public PokemonHat(string roleName) : base(roleName)
        {
        }
    }
}