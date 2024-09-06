
using System.Text;


namespace LINQSamples
{
    public class ProductStats
    {
        #region Constructor
        public ProductStats() 
        {
            TotalProducts = 0;
            TotalListPrice = 0;
            MinListPrice = decimal.MaxValue;
            MaxListPrice = decimal.MaxValue;
            AverageListPrice = decimal.MaxValue;
        }
        #endregion

        public string Size { get; set; }
        public int TotalProducts { get; set; }
        public decimal TotalListPrice { get; set; }
        public decimal MinListPrice { get; set; }
        public decimal MaxListPrice { get; set; }
        public decimal AverageListPrice  { get;set; }

    }
}
