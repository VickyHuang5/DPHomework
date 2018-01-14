using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    /// <summary>
    /// 電腦
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 電腦零件
        /// </summary>
        private IList<string> computerParts = new List<string>();

        /// <summary>
        /// 加入
        /// </summary>
        /// <param name="part">零件</param>
        public void Add(string part)
        {
            this.computerParts.Add(part);
        }

        /// <summary>
        /// 呈現
        /// </summary>
        public void Show()
        {
            foreach (string part in this.computerParts)
            {
                Console.WriteLine(part);
            }
        }
    }
}