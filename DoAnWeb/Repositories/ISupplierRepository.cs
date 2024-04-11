using DoAnWeb.Model;

public interface ISupplierRepository
{
    Task<IEnumerable<Supplier>> GetAllAsync();
    Task<Supplier> GetByIdAsync(int id);
    Task AddAsync(Supplier category);
    Task UpdateAsync(Supplier category);
    Task DeleteAsync(int id);
}
