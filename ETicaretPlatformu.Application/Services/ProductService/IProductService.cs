using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
using ETicaretPlatformu.Application.Models.VMs.ProductVMs;
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

        Task<AddProductDto> AddProduct();

        Task UpdateProduct(UpdateProductDto model);

        Task Delete(int id);

        Task<List<ProductVM>> GetProducts();

        Task<UpdateProductDto> GetById(int id);

        Task<ProductDetailsVM> GetProductDetails(int id);

    }
}
