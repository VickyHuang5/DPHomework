namespace AbstractFactory
{
    /// <summary>
    /// 寶可夢頭盔
    /// </summary>
    public class PokemonHelmet : AbstractHelmet
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public PokemonHelmet(string roleName) : base(roleName)
        {
        }
    }
}