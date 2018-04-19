using System;

namespace CompositePattern
{
    /// <summary>
    /// 主程式
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 主程式
        /// </summary>
        /// <param name="args">執行參數</param>
        private static void Main(string[] args)
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();
            shoppingCartService.AddCart(new AppleNintendoCombo());
            double result = shoppingCartService.CalculatePrice();
            Console.WriteLine("{0}", result);
            Console.ReadKey();
        }
    }
}