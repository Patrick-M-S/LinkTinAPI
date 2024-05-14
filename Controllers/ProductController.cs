using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(long id)
    {
        var product = await _productService.GetProductById(id);
        if (product == null)
        {
            return BadRequest("Nenhum produto encontrado para o ID informado.");
        }
        return Ok(product);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _productService.GetAllProducts();
        if (products == null)
        {
            return BadRequest("Não há nenhum produto cadastrado");
        }
        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> AddProduct([FromBody] ProductModel product)
    {
        try
        {
            await _productService.AddProduct(product);
            return Ok("Cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(long id, [FromBody]ProductModel product)
    {
        try
        {
            await _productService.UpdateProduct(id, product);
            return Ok("Atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(long id)
    {
        try
        {
            await _productService.DeleteProduct(id);
            return Ok("Deletado com sucesso!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}