using Microsoft.EntityFrameworkCore;

public class ProductRepository : IProductRepository
{
    private readonly MyDbContext _context;

    public ProductRepository(MyDbContext context)
    {
        _context = context;
    }

    public async Task<ProductModel> GetProductById(long id)
    {
        return await _context.ProductRegister.FindAsync(id);
    }
    public async Task<List<ProductModel>> GetAllProducts()
    {
        return await _context.ProductRegister.ToListAsync();
    }

    public async Task AddProduct (ProductModel product)
    {
        await _context.ProductRegister.AddAsync(product);
        _context.SaveChanges();
    }

    public async Task UpdateProduct (long id, ProductModel product)
    {
        var productToUpdate = await _context.ProductRegister.FindAsync(id);

        if (productToUpdate != null)
        {
            productToUpdate.Id = product.Id;
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;

            _context.ProductRegister.Update(productToUpdate);

            await _context.SaveChangesAsync();
        }
        else
        {
            throw new Exception("Produto não encontrado");
        }    
    }
    public async Task DeleteProduct (long id)
    {
        var produto = await _context.ProductRegister.FindAsync(id);
        if (produto == null)
            throw new Exception("Produto não encontrado");

        _context.ProductRegister.Remove(produto);
        await _context.SaveChangesAsync();
    }
}