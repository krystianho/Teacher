﻿using System.Threading.Tasks;
using Teacher.Website.Infrastructure;

namespace Teacher.Website.Feature.Category.CreateUpdate
{
    public interface IRepository : IRepositoryMarker
    {
        Task<ViewModel.CategoryViewModel> GetCategoryAsync(int categoryId);
        Task CreateCategoryAsync(string name);
        Task UpdateCategoryAsync(int id, string name);
    }
}