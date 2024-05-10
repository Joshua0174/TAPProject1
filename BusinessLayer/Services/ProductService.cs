using BusinessLayer.Contracts;
using DataAccessLayer.Models;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public Product Create(Product reviewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _repository.GetAllWithReviews().ToList();
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Guid id, Product reviewModel)
        {
            throw new NotImplementedException();
        }
    }
}
