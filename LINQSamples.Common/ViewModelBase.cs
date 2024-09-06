

namespace LINQSamples
{
    public class ViewModelBase {
        #region GetProducts Method
        protected List<Products> GetProducts()
        {
            return ProductRepository.GetAll();
        }
        #endregion
    }
}


