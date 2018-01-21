namespace AbstractFactory
{
    /// <summary>
    /// 寶可夢Cosplay服裝工廠
    /// </summary>
    public class PokemonCosplayClothingFactory : AbstractCosplayClothingFactory
    {
        /// <summary>
        /// 角色名稱
        /// </summary>
        protected string RoleName;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public PokemonCosplayClothingFactory(string roleName)
        {
            this.RoleName = roleName;
        }

        /// <summary>
        /// 生產帽子
        /// </summary>
        /// <returns>帽子</returns>
        public override AbstractHat ProduceHat()
        {
            return new PokemonHat(this.RoleName);
        }

        /// <summary>
        /// 生產頭盔
        /// </summary>
        /// <returns>頭盔</returns>
        public override AbstractHelmet ProduceHelmet()
        {
            return new PokemonHelmet(this.RoleName);
        }

        /// <summary>
        /// 生產盔甲
        /// </summary>
        /// <returns>盔甲</returns>
        public override AbstractArmor ProduceArmor()
        {
            return new PokemonArmor(this.RoleName);
        }

        /// <summary>
        /// 生產靴子
        /// </summary>
        /// <returns>靴子</returns>
        public override AbstractBoots ProduceBoots()
        {
            return new PokemonBoots(this.RoleName);
        }

        /// <summary>
        /// 生產武器
        /// </summary>
        /// <returns>武器</returns>
        public override AbstractWeapon ProduceWeapon()
        {
            return new PokemonWeapon(this.RoleName);
        }
    }
}