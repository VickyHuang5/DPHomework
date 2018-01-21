namespace AbstractFactory
{
    /// <summary>
    /// 抽象Cosplay服裝工廠
    /// </summary>
    public abstract class AbstractCosplayClothingFactory
    {
        /// <summary>
        /// 生產帽子
        /// </summary>
        /// <returns>帽子</returns>
        public abstract AbstractHat ProduceHat();

        /// <summary>
        /// 生產頭盔
        /// </summary>
        /// <returns>頭盔</returns>
        public abstract AbstractHelmet ProduceHelmet();

        /// <summary>
        /// 生產盔甲
        /// </summary>
        /// <returns>盔甲</returns>
        public abstract AbstractArmor ProduceArmor();

        /// <summary>
        /// 生產靴子
        /// </summary>
        /// <returns>靴子</returns>
        public abstract AbstractBoots ProduceBoots();

        /// <summary>
        /// 生產武器
        /// </summary>
        /// <returns>武器</returns>
        public abstract AbstractWeapon ProduceWeapon();
    }
}