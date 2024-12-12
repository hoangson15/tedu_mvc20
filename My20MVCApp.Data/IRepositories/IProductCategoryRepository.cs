using My20MVCApp.Data.Entities;
using My20MVCApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace My20MVCApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
