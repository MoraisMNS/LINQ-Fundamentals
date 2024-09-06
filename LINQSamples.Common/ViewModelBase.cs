
namespace LINQSamples
{
    public class ViewModelBase {
        #region GetProducts Method
        protected List<Products> GetProducts()
        {
            //Load all Product Data
            return ProductRepository.GetAll();
        }
        #endregion

        #region GetSales Method

        protected List <SalesOrder> GetSale()
        {
            //Load all sales Data
            return SalesOrderRepository.GetAll();
        }
    #endregion

    #region Display Methods
    protected void Display(List<Product> products)
    {
        foreach (Product product i)
    }
}
}


