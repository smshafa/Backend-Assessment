﻿using Backend_Assessment.Application.Features.Dto.Category;
using Backend_Assessment.Models;

namespace Backend_Assessment.Repositories;

public interface ICategoryRepository : IGenericRepository<Category, int>
{
    IQueryable<CategoryDto> GetOne(int id);
}