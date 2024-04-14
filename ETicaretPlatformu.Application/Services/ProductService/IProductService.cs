using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
using ETicaretPlatformu.Application.Models.VMs.ProductVMs;
using ETicaretPlatformu.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.ProductService
{
    public interface IProductService
    {
        Task Add(AddProductDto model);

        //Task<AddProductDto> AddProduct();

        Task UpdateProduct(UpdateProductDto model);

        Task Delete(int id);

        Task<List<ProductVM>> GetProducts();

        Task<UpdateProductDto> GetById(int id);

        Task<ProductDetailsVM> GetProductDetails(int id);

        Task<string> SaveFile(IFormFile file);

        Task<List<ProductVM>> GetByCategory(int categoryId);


        Task<List<ProductVM>> SearchByName(string term = "");

        Task<List<ProductVM>> FilterByPrice(decimal maxPrice, decimal minPrice = 0);

        Task DecreaseStockQuantity(int productId, int quantity);

    }
}
