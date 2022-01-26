using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary.Data;

namespace WcfServiceLibrary.Class
{
   public class DALBase
    {
        public ProductsEntities dbContecxt { get; set; }

    }
}
