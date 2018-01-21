using System;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象靴子
    /// </summary>
    public abstract class AbstractBoots
    {
        /// <summary>
        /// 角色名稱
        /// </summary>
        protected string RoleName;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public AbstractBoots(string roleName)
        {
            this.RoleName = roleName;
        }

        /// <summary>
        /// 生產角色靴子
        /// </summary>
        /// <returns>角色靴子</returns>
        public string ProduceBootsOfRole()
        {
            return $"生產{RoleName}靴子";
        }
    }
}