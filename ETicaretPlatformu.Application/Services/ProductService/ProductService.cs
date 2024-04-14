using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.ProductDTOs;
using ETicaretPlatformu.Application.Models.VMs.CatagoryVM;
using ETicaretPlatformu.Application.Models.VMs.ProductVMs;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            product.Name = model.Name;
            product.Description = model.Description;
            product.Price = model.Price;
            product.StockQuantity = model.StockQuantity;
            product.CategoryId = model.CategoryId;
            product.ImagePath = model.ImagePath;

            await _productRepo.Create(product);
        }

        public async Task<string> SaveFile(IFormFile file)
        {
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var filePath = Path.Combine(directory, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return "/images/" + fileName;
        }

        public async Task UpdateProduct(UpdateProductDto model)
        {

            var product = await _productRepo.GetDefault(x => x.Id == model.Id);

            if (product is not null)
            {

                if (product.CategoryId != model.CategoryId)
                {
                    product.CategoryId = model.CategoryId;
                    product.Category = await _categoryRepo.GetDefault(x => x.Id == model.CategoryId);
                }


                if (model.UploadPath != null && model.UploadPath.Length > 0)
                {

                    string fileName = $"{Guid.NewGuid()}{Path.GetExtension(model.UploadPath.FileName)}";
                    string uploadDirectory = Path.Combine("wwwroot", "images");
                    Directory.CreateDirectory(uploadDirectory);
                    string filePath = Path.Combine(uploadDirectory, fileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await model.UploadPath.CopyToAsync(stream);
                    }

                    product.ImagePath = $"/{Path.Combine("images", fileName)}";
                }
                else
                {
                    product.ImagePath = model.ImagePath ?? product.ImagePath;
                }

                product.Name = model.Name;
                product.Description = model.Description;
                product.Price = model.Price;
                product.StockQuantity = model.StockQuantity;
                product.CategoryId = model.CategoryId;
                product.ImagePath = model.ImagePath;

                await _productRepo.Update(product);
            }
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



        public async Task<List<ProductVM>> GetProducts()
        {
            var products = await _productRepo.GetFilteredList(
                select: x => new ProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    StockQuantity = x.StockQuantity,
                    CategoryName = x.Category.Name,
                    ImagePath = x.ImagePath
                },
                where: x => x.Status != Domain.Enums.Status.Passive,
                orderBy: x => x.OrderBy(x => x.Name),
                include: x => x.Include(x => x.Category
                ));

            return products;
        }

        public async Task<UpdateProductDto> GetById(int id)
        {
            var product = await _productRepo.GetFilteredFirstOrDefault(
                     select: x => new ProductVM
                     {
                         Id = x.Id,
                         Name = x.Name,
                         Description = x.Description,
                         Price = x.Price,
                         StockQuantity = x.StockQuantity,
                         CategoryId = x.CategoryId,
                         ImagePath = x.ImagePath
                     },
                where: x => x.Id == id
                );
            var model = _mapper.Map<UpdateProductDto>(product);

            return model;
        }

        public async Task<ProductDetailsVM> GetProductDetails(int id)
        {
            var product = await _productRepo.GetFilteredFirstOrDefault(
                select: x => new ProductDetailsVM
                {
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    StockQuantity = x.StockQuantity,
                    CategoryName = x.Category.Name,
                    ImagePath = x.ImagePath,
                    CreateDate = x.CreateDate,
                    Status = x.Status
                },
                where: x => x.Id == id,
                orderBy: x => x.OrderBy(x => x.Name),
                include: x => x.Include(x => x.Category)
                );

            return product;
        }

        public async Task<List<ProductVM>> GetByCategory(int categoryId)
        {
            var productList = await _productRepo.GetFilteredList(
                select: x => new ProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    ImagePath = x.ImagePath,
                },
                where: x => x.Category.Id == categoryId && x.Status != Domain.Enums.Status.Passive);


            return productList;
        }

        public async Task<List<ProductVM>> FilterByPrice(decimal maxPrice, decimal minPrice = 0)
        {
            if (maxPrice == 0)
            {
                var urunFiyatlari = await _productRepo.GetFilteredList(
             select: x => new ProductVM
             {
                 Price = x.Price
             },
             where: null);

                var enPahaliUrun = urunFiyatlari.OrderByDescending(x => x.Price).FirstOrDefault();

                maxPrice = enPahaliUrun.Price;
            }

            var productList = await _productRepo.GetFilteredList(
                select: x => new ProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    ImagePath = x.ImagePath,
                },
                where: x => x.Price >= minPrice && x.Price <= maxPrice && x.Status!=Domain.Enums.Status.Passive);

            return productList;
        }

        public async Task<List<ProductVM>> SearchByName(string term="")
        {
            term = string.IsNullOrEmpty(term) ? "" : term.ToLower();

            

            if (string.IsNullOrEmpty(term))
            {
                
               var products = await _productRepo.GetFilteredList(
               select: x => new ProductVM
               {
                   Id = x.Id,
                   Name = x.Name,
                   Price = x.Price,                   
                   ImagePath = x.ImagePath
               },
               where: x => x.Status != Domain.Enums.Status.Passive             
               );

                return products;
            }
            else
            {
                var products = await _productRepo.GetFilteredList(
                select: x => new ProductVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    ImagePath = x.ImagePath
                },
                where: x => x.Status != Domain.Enums.Status.Passive && x.Name.ToLower().StartsWith(term)
                );

                return products;
            }

             
        }

        public async Task DecreaseStockQuantity(int productId, int quantity)
        {
            var product = await _productRepo.GetDefault(x => x.Id == productId);

            if (product != null)
            {
                if (product.StockQuantity < quantity)
                {
                    product.StockQuantity = 0;
                }
                else
                {
                    product.StockQuantity -= quantity;
                }

                await _productRepo.Update(product);
            }
        }
    }
}

