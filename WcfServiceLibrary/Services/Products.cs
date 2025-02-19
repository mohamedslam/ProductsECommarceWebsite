﻿using DTO.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Products : IProducs
    {
        public List<ProductDto> GetAllProducts()
        {
            return new DALProducts().GetProducts();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public ProductDto GetProductByID(long productId)
        {
            return new DALProducts().GetProductById(productId);
        }

      
    }
}
