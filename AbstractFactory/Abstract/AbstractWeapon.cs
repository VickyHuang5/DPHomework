using System;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象武器
    /// </summary>
    public abstract class AbstractWeapon
    {
        /// <summary>
        /// 角色名稱
        /// </summary>
        protected string RoleName;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public AbstractWeapon(string roleName)
        {
            this.RoleName = roleName;
        }

        /// <summary>
        /// 生產角色武器
        /// </summary>
        /// <returns>角色武器</returns>
        public string ProducWeaponOfRole()
        {
            return $"生產{RoleName}武器";
        }
    }
}