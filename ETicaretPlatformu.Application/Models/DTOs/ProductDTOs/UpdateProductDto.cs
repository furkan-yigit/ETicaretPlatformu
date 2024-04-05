using ETicaretPlatformu.Application.Extensions;
using ETicaretPlatformu.Application.Models.VMs.CatagoryVM;
using ETicaretPlatformu.Application.Models.VMs.ProductVMs;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.ProductDTOs
{
    public class UpdateProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen ürün ismi giriniz")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Lütfen ürün fiyatı giriniz")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Lütfen stok miktarı giriniz")]
        public int StockQuantity { get; set; }
        [Required(ErrorMessage = "Lütfen kategori seçiniz")]
        public int CategoryId { get; set; }

        //public List<CatagoryVM> Categories { get; set; }

        public string? ImagePath { get; set; }
        
        [PictureFileExtensionAttiribute]
        public IFormFile? UploadPath { get; set; }
        public DateTime? UpdateDate => DateTime.Now;

        public Status Status => Status.Modified;
    }
}
