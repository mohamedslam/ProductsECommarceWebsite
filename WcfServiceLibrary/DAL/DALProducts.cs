using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary.Class;
namespace WcfServiceLibrary
{
   public class DALProducts:DALBase
    {
        public List<Products> GetProducts()
        {
            var rst = from t in dbContecxt.ItemControls
                      select new Products {
                          ProductId=t.ID,
                          Price=t.DefultPrice,
                          ProductName=t.Name,
                      };
            return rst.ToList();
        }
        public Products GetProductById(long ProductID)
        {
            var rst = (from t in dbContecxt.ItemControls
                      where t.ID== ProductID
                      select new Products
                      {
                          ProductId = t.ID,
                          Price = t.DefultPrice,
                          ProductName = t.Name,
                      }).FirstOrDefault();
            return rst;
        }
    }
}
