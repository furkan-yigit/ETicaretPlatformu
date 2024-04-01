using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
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


    }
}
