namespace CompositePattern
{
    /// <summary>
    /// AppleWatch
    /// </summary>
    public class AppleWatch : AbstractSingleProduct
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