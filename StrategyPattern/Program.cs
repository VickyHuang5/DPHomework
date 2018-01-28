using System;

namespace StrategyPattern
{
    /// <summary>
    /// 主程式
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主程式
        /// 平日全商品打八折(折扣後金額無條件進位)
        /// 周末滿一千折抵100
        /// 執行參數範例：A2018001 1993
        /// </summary>
        /// <param name="args">執行參數</param>
        private static void Main(string[] args)
        {
            IDiscount discount;
            string orderId = args[0];
            string dayOfWeek = string.Empty;
            int originalPrice = Convert.ToInt32(args[1]);
            int day = ((int)DateTime.Now.DayOfWeek == 0) ? 7 : (int)DateTime.Now.DayOfWeek;
            if (day > 5)
            {
                discount = new FullDiscount();
                dayOfWeek = "周末滿千送百";
            }
            else
            {
                discount = new DiscountForAllItems();
                dayOfWeek = "平日全商品八折";
            }

            Order order = new Order(orderId, originalPrice);
            int checkoutAmount = order.CalculateDiscount(discount);
            Console.WriteLine($"{dayOfWeek}，訂單{orderId}：原始價格{ originalPrice }，結帳金額{checkoutAmount}");
            Console.ReadKey();
        }
    }
}