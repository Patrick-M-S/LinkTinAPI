public interface IProductService
{
    Task<ProductModel> GetProductById (long id);
    Task<List<ProductModel>> GetAllProducts();
    Task AddProduct(ProductModel product);
    Task UpdateProduct (long id, ProductModel product);   
    Task DeleteProduct (long id);
}