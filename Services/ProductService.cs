public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ProductModel> GetProductById(long id)
    {
        return await _productRepository.GetProductById(id);
    }

    public async Task<List<ProductModel>> GetAllProducts()
    {
        return await _productRepository.GetAllProducts();
    }

    public async Task AddProduct(ProductModel product)
    {
        await _productRepository.AddProduct(product);
    }

    public async Task UpdateProduct (long id, ProductModel product)
    {
        await _productRepository.UpdateProduct(id, product);
    }

    public async Task DeleteProduct (long id)
    {
        await _productRepository.DeleteProduct(id);
    }
}