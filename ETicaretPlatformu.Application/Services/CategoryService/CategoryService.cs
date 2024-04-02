using AutoMapper;
using ETicaretPlatformu.Application.Models.DTOs.CatagoryDto;
using ETicaretPlatformu.Application.Models.VMs.CatagoryVM;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Enums;
using ETicaretPlatformu.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IMapper _mapper;
        

        public CategoryService(ICategoryRepo categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
            
        }
        public async Task Create(CreateCatogoryDto model)
        {
            var category = _mapper.Map<Category>(model);
            await _categoryRepo.Create(category);
           
        }

        public async Task Delete(int id)
        {
           Category category = await _categoryRepo.GetDefault(x => x.Id == id);
            await _categoryRepo.Delete(category);
            
        }

        public async Task<UpdateCatagoryDto> GetById(int id)
        {
            var category = await _categoryRepo.GetFilteredFirstOrDefault(
               select: x => new CatagoryVM 
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                },
               where: x => x.Id == id
                );
            return _mapper.Map<UpdateCatagoryDto>(category);

            
        }

        public Task<List<CatagoryVM>> GetCatagories()
        
        {
            var categories = _categoryRepo.GetFilteredList(
                               select: x => new CatagoryVM
                               {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                },
                                              where: x => x.Status != Status.Passive,
                                              orderBy: x => x.OrderBy(x => x.Name)
                                                             );
            return categories;

            
        }

        

        public Task<bool> IsCatagoryExist(string name)
        {
            var isExist = _categoryRepo.Any(x => x.Name == name);
            return isExist;
            
        }

        public async Task Update(UpdateCatagoryDto model)
        {
            var category = _mapper.Map<Category>(model);
           await _categoryRepo.Update(category);
                        
        }
    }
}
