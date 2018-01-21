using System;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象帽子
    /// </summary>
    public abstract class AbstractHat
    {
        /// <summary>
        /// 角色名稱
        /// </summary>
        protected string RoleName;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public AbstractHat(string roleName)
        {
            this.RoleName = roleName;
        }

        /// <summary>
        /// 生產角色帽子
        /// </summary>
        /// <returns>角色帽子</returns>
        public string ProduceHatOfRole()
        {
            return $"生產{RoleName}帽子";
        }
    }
}