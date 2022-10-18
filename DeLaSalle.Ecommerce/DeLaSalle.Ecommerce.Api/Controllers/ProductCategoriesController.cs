using System.Diagnostics;
using DeLaSalle.Ecommerce.Api.Repositories.Interfaces;
using DeLaSalle.Ecommerce.Core.Entities;
using DeLaSalle.Ecommerce.Core.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeLaSalle.Ecommerce.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductCategoriesController : ControllerBase
{
    private readonly IProductCategoryRepository _productCategoryRepository;
    
    public ProductCategoriesController(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<Response<List<ProductCategory>>>> GetAll()
    {
        var response = new Response<List<ProductCategory>>();
        var categories = await _productCategoryRepository.GetAllAsync();
        response.Data = categories;
        return Ok(response);
    }
    
    [HttpPost]
    public async Task<ActionResult<Response<ProductCategory>>> Post([FromBody] ProductCategory category)
    {
        category = await _productCategoryRepository.SaveAsync(category);
       
        var response = new Response<ProductCategory>();
        response.Data = category;
        
        return Created($"/api/[controler]/{category.Id}",response);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<ProductCategory>>> GetById( int id )
    {
        var response = new Response<ProductCategory>();
        var category = await _productCategoryRepository.GetById(id);
        response.Data = category;
        
        if (category == null)
        {
            response.Errors.Add("Product Category Not Found");
            return NotFound(response);
        }

        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Response<ProductCategory>>> Update([FromBody] ProductCategory category)
    {
        var result = await _productCategoryRepository.UpdateAsync(category);
        var response = new Response<ProductCategory>{ Data = result};
        return Ok(response);
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete(int id)
    {
        var response = new Response<bool>();
        var result = await _productCategoryRepository.DeleteAsync(id);
        response.Data = result;
        
        return Ok(response);
    }
    
}
