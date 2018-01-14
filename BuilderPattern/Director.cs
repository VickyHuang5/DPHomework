using System;

namespace BuilderPattern
{
    /// <summary>
    /// 導向器
    /// </summary>
    internal class Director
    {
        /// <summary>
        /// 建構
        /// </summary>
        /// <param name="builder">建造器</param>
        /// <param name="specification">規格</param>
        public void Construct(Builder builder, string[] specification)
        {
            try
            {
                builder.AddCpu(specification[1])
                       .AddRam(Convert.ToInt32(specification[2]))
                       .AddHd(Convert.ToInt32(specification[3]))
                       .AddGraphicsCard(specification[4]);
            }
            catch
            {
                Console.WriteLine("請於品牌後依序輸入CPU型號 RAM大小(數字) HD大小(數字) 顯示卡型號，例：Asus intel-core-i7 8 500 GV-N710D5-2GL");
            }
        }
    }
}