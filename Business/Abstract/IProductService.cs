using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService : IEntityService<Product>
    {
        public List<ProductDetailsDto> GetProductDetails();
    }
}