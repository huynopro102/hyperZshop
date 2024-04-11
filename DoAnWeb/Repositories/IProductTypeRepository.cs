using DoAnWeb.Model;
public interface IProductTypeRepository
{
    Task<IEnumerable<ProductType>> GetAllAsync();
    Task<ProductType> GetByIdAsync(int id);
    Task AddAsync(ProductType category);
    Task UpdateAsync(ProductType category);
    Task DeleteAsync(int id);
}
