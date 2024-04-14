using ETicaretPlatformu.Application.Models.DTOs.CatagoryDto;
using ETicaretPlatformu.Application.Models.VMs.CatagoryVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.CategoryService
{
    public interface ICategoryService
    {
        Task Create(CreateCatogoryDto model);
        Task Update(UpdateCatagoryDto model);
        Task Delete(int id);
        Task<List<CatagoryVM>> GetCatagories();

        Task<UpdateCatagoryDto> GetById(int id);
        Task<bool> IsCatagoryExist(string name);

     
    }
}
