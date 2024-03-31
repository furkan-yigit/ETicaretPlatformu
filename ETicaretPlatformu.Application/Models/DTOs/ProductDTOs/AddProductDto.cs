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
    public class AddProductDto
    {
        [Required(ErrorMessage = "Ürün ismi girilmek zorundadır")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ürün açıklaması girilmek zorundadır")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ürün fiyatı girilmek zorundadır")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stok miktarı girilmek zorundadır")]
        public int StockQuantity { get; set; }

        [Required(ErrorMessage = "Kategori seçilmek zorundadır")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string? ImagePath { get; set; }

        [NotMapped]
        public IFormFile? UploadPath { get; set; }

        public DateTime CreateDate=>DateTime.Now;

        public Status Status => Status.Active;
    }
}
