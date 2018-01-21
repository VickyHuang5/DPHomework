using System;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象盔甲
    /// </summary>
    public abstract class AbstractArmor
    {
        /// <summary>
        /// 角色名稱
        /// </summary>
        protected string RoleName;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public AbstractArmor(string roleName)
        {
            this.RoleName = roleName;
        }

        /// <summary>
        /// 生產角色盔甲
        /// </summary>
        /// <returns>角色盔甲</returns>
        public string ProduceArmorOfRole()
        {
            return $"生產{RoleName}盔甲";
        }
    }
}