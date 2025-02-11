using DotnetAssignment.Data;
using Microsoft.EntityFrameworkCore;

public class ProductService
{
    private readonly ApplicationDbContext _context;

    public ProductService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<List<Product>> GetAllProduct()
    {
        return await _context.Products.ToListAsync();
    }
    public async Task<Product> GetProductByIdAsync(string id)
    {
        return await _context.Products.FindAsync(id);
    }
}