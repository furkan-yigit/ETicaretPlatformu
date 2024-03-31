using ETicaretPlatformu.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Models.DTOs.CatagoryDto
{
    public class UpdateCatagoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Bir kategori adı giriniz!")]
        [MinLength(3, ErrorMessage = "Lütfen en az 3 karakter giriniz!")]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime UpdateDate => DateTime.Now;
        public Status Status => Status.Modified;

    }
}
