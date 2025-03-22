// CMS.Infrastructure/Repositories/ProductRepository.cs
using CMS.Core.Models;
using CMS.Infrastructure.Data;

namespace CMS.Infrastructure.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }
}

public interface IProductRepository : IRepository<Product>
{
}