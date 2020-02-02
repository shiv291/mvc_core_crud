using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventory.Datalayer.Models;
using Inventory.Datalayer.Repository;

namespace Inventory.BusinessLib
{
    public class ProductOperation : IProductOperation
    {
        public IList<Products> GetProducts()
        {
            try
            {                
                IDbRepository<Products> ProdOperation = new DbRepository<Products>();
                var result= ProdOperation.FindAll();
                return result.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public interface IProductOperation
    {
        IList<Products> GetProducts();
    }
}
