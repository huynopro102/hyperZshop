﻿using Microsoft.EntityFrameworkCore;
using DoAnWeb.Model;

public class EFProductRepository : IProductRepository
{
    private readonly CsdlwebContext _context;

    public EFProductRepository(CsdlwebContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        // return await _context.Products.ToListAsync();
        return await _context.Products.Include(p => p.IdproductTypeNavigation).Include(p => p.IdsupplierNavigation).ToListAsync();
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        // return await _context.Products.FindAsync(id);
        // lấy thông tin kèm theo category
        return await _context.Products
         .Include(p => p.IdproductTypeNavigation)
        .Include(p => p.IdsupplierNavigation)
        .FirstOrDefaultAsync(p => p.Idproduct == id);
    }

    public async Task AddAsync(Product product)
    {       
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Product product)
    {
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var product = await _context.Products.FindAsync(id);
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
    }

}