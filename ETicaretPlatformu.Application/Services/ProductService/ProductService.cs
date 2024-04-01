using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
using ETicaretPlatformu.Application.Models.VMs.ProductVMs;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Repositories;
using Microsoft.Extensions.Hosting;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;

        public ProductService(IProductRepo productRepo, IMapper mapper, ICategoryRepo categoryRepo)
        {
            _productRepo = productRepo;
            _mapper = mapper;
            _categoryRepo = categoryRepo;
        }

        public async Task Add(AddProductDto model)
        {
            var product = _mapper.Map<Product>(model);

            if (product.UploadPath != null)
            {
                using var image = Image.Load(model.UploadPath.OpenReadStream());
                image.Mutate(x => x.Resize(600, 560));
                Guid guid = Guid.NewGuid();
                image.Save($"wwwroot/images/{guid}.png");
                product.ImagePath = $"wwwroot/images/{guid}.png";

                await _productRepo.Create(product);
            }
            else
            {
                product.ImagePath = $"/images/defaultpost.png";
                await _productRepo.Create(product);
            }
        }
        public async Task<AddProductDto> AddProduct()
        {
            AddProductDto model = new AddProductDto()
            {
                Categories = await _categoryRepo.GetFilteredList(
                    select: x => new ProductCategoryVM
                    {
                        Id = x.Id,
                        Name = x.Name
                    },
                    where: x => x.Status != Domain.Enums.Status.Passive,
                    orderBy: x => x.OrderBy(x => x.CreateDate)
                    )
            };
            return model;
        }

        public async Task Delete(int id)
        {
            var deletedProduct = await _productRepo.GetDefault(x => x.Id.Equals(id));

            if (deletedProduct is not null)
            {
                deletedProduct.Status = Domain.Enums.Status.Passive;
                deletedProduct.DeleteDate = DateTime.Now;
                await _productRepo.Update(deletedProduct);
            }
        }

        public async Task UpdateProduct(UpdateProductDto model)
        {
            //var product = _mapper.Map<Product>(model);

            var product = await _productRepo.GetDefault(x => x.Id == model.Id);

            if (product is not null)
            {
                _mapper.Map(model, product);

                if (product.CategoryId != model.CategoryId)
                {
                    product.CategoryId = model.CategoryId;
                    product.Category= await _categoryRepo.GetDefault(x => x.Id==model.CategoryId);
                }

                if (product.UploadPath != null)
                {
                    using var image = Image.Load(model.UploadPath.OpenReadStream());
                    image.Mutate(x => x.Resize(600, 560));
                    Guid guid = Guid.NewGuid();
                    image.Save($"wwwroot/images/{guid}.png");
                    product.ImagePath = $"wwwroot/images/{guid}.png";                    
                }
                else
                {
                    product.ImagePath = model.ImagePath;                    
                }

                await _productRepo.Update(product);
            }

           
        }
    }
}

