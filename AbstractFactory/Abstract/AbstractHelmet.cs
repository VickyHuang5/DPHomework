using System;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象頭盔
    /// </summary>
    public abstract class AbstractHelmet
    {
        /// <summary>
        /// 角色名稱
        /// </summary>
        protected string RoleName;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="roleName">角色名稱</param>
        public AbstractHelmet(string roleName)
        {
            this.RoleName = roleName;
        }

        /// <summary>
        /// 生產角色頭盔
        /// </summary>
        /// <returns>角色頭盔</returns>
        public string ProduceHelmetOfRole()
        {
            return $"生產{RoleName}頭盔";
        }
    }
}