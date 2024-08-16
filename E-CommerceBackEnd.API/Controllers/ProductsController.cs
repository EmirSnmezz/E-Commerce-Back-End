using E_Commerce.Application.Abstractions.Entites;
using E_Commerce.Application.Abstractions.Repositories.Reposiyories_Of_Entities.Product_Repositories;
using E_Commerce.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceBackEnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;   
        }
        [HttpGet]
        public async void Index()
        {
            _productWriteRepository.AddRangeAsync(new List<Product>()
            {
                new() {ID =  Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Product1", Price = 100, Stock = 100 },
                new() {ID =  Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Product2", Price = 8100, Stock = 200 },
                new() {ID =  Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Product3", Price = 700, Stock = 300 },
                new() {ID =  Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Product4", Price = 600, Stock = 400 },
                new() {ID =  Guid.NewGuid(), CreatedDate = DateTime.UtcNow, Name = "Product5", Price = 500, Stock = 500 }
            });

            var count = await _productWriteRepository.SaveAsync();
        }
    }
}
