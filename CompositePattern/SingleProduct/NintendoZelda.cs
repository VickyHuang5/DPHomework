namespace CompositePattern
{
    /// <summary>
    /// 薩爾達
    /// </summary>
    public class NintendoZelda : AbstractSingleProduct
    {
        /// <summary>
        /// 價格
        /// </summary>
        protected override double Price
        {
            get { return 2000; }
        }
    }
}