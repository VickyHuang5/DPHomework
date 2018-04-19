namespace CompositePattern
{
    /// <summary>
    /// MacBookPro
    /// </summary>
    public class AppleMacBookPro : AbstractSingleProduct
    {
        /// <summary>
        /// 價格
        /// </summary>
        protected override double Price
        {
            get { return 60000; }
        }
    }
}