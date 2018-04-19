using System.Collections.Generic;
using System.Linq;

namespace CompositePattern
{
    /// <summary>
    /// 購物車服務
    /// </summary>
    public class ShoppingCartService
    {
        /// <summary>
        /// 購物車
        /// </summary>
        private readonly List<IPrice> Carts = new List<IPrice>();

        /// <summary>
        /// 加入購物車
        /// </summary>
        /// <param name="product">商品</param>
        public void AddCart(IPrice product)
        {
            this.Carts.Add(product);
        }

        /// <summary>
        /// 計算價格
        /// </summary>
        /// <returns>價格</returns>
        public double CalculatePrice()
        {
            return this.Carts.Sum(product => product.GetPrice());
        }
    }
}