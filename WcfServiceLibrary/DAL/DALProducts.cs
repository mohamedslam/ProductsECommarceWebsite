using DTO.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary.Class;
using WcfServiceLibrary.Data;
 
namespace WcfServiceLibrary
{
   public class DALProducts:DALBase
    {
        public List<ProductDto> GetProducts()
        {
            var rst = from t in DbContecxt.ItemControls
                      select new ProductDto {
                          ProductId=t.ID,
                          Price=t.DefultPrice,
                          ProductName=t.Name,
                      };
            return rst.ToList();
        }
        public ProductDto GetProductById(long ProductID)
        {
            var rst = (from t in DbContecxt.ItemControls
                      where t.ID== ProductID
                      select new ProductDto
                      {
                          ProductId = t.ID,
                          Price = t.DefultPrice,
                          ProductName = t.Name,
                      }).FirstOrDefault();
            return rst;
        }
    }
}
