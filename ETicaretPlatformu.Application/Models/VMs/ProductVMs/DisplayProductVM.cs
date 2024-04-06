using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.VMs.ProductVMs
{
    public class DisplayProductVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? ImagePath { get; set; }
    }
}
