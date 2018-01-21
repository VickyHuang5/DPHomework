using System;

namespace AbstractFactory
{
    /// <summary>
    /// Cosplay服裝店
    /// </summary>
    public class CosplayClothingStore
    {
        /// <summary>
        /// 帽子
        /// </summary>
        private readonly AbstractHat Hat;

        /// <summary>
        /// 頭盔
        /// </summary>
        private readonly AbstractHelmet Helmet;

        /// <summary>
        /// 盔甲
        /// </summary>
        private readonly AbstractArmor Armor;

        /// <summary>
        /// 靴子
        /// </summary>
        private readonly AbstractBoots Boots;

        /// <summary>
        /// 武器
        /// </summary>
        private readonly AbstractWeapon Weapon;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="factory">Cosplay服裝工廠</param>
        public CosplayClothingStore(AbstractCosplayClothingFactory factory)
        {
            this.Hat = factory.ProduceHat();
            this.Helmet = factory.ProduceHelmet();
            this.Armor = factory.ProduceArmor();
            this.Boots = factory.ProduceBoots();
            this.Weapon = factory.ProduceWeapon();
        }

        /// <summary>
        /// 產出角色服裝
        /// </summary>
        public void OutputClothingOfRole()
        {
            Console.WriteLine(this.Hat.ProduceHatOfRole());
            Console.WriteLine(this.Helmet.ProduceHelmetOfRole());
            Console.WriteLine(this.Armor.ProduceArmorOfRole());
            Console.WriteLine(this.Boots.ProduceBootsOfRole());
            Console.WriteLine(this.Weapon.ProducWeaponOfRole());
        }
    }
}