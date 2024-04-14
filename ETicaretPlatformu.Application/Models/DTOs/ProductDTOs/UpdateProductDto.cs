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
        [Required(ErrorMessage = "Please enter a product name!")]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required(ErrorMessage = "Please enter a price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a stock quantity")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be greater than 0!")]
        public int StockQuantity { get; set; }

        [Required(ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }
        public string? ImagePath { get; set; }
        
        [PictureFileExtensionAttiribute]
        public IFormFile? UploadPath { get; set; }
        public DateTime? UpdateDate => DateTime.Now;

        public Status Status => Status.Modified;
    }
}
