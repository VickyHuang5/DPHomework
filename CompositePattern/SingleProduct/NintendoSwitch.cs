namespace CompositePattern
{
    /// <summary>
    /// Switch
    /// </summary>
    public class NintendoSwitch : AbstractSingleProduct
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