using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public Product GetById(Guid id);
        public Product Create(Product productModel);
        public Product Update(Guid id,Product productModel);
        public void Delete(Guid id);
    }
}
