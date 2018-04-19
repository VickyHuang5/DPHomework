namespace CompositePattern
{
    /// <summary>
    /// iPadAir
    /// </summary>
    public class AppleIPadAir : AbstractSingleProduct
    {
        /// <summary>
        /// 價格
        /// </summary>
        protected override double Price
        {
            get { return 10000; }
        }
    }
}