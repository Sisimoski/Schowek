﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchowekWeb.Models;

namespace SchowekWeb.Data
{
    public interface IDataAccess
    {
        // Categories (Clipboards) data access
        Task<List<Category>> GetCategories();
        Task<Category> GetCategory(int categoryId);
        Task<List<Category>> GetUsersCategories(string userId);
        Task<Category> AddCategory(Category category);
        Task<Category> UpdateCategory(Category category);
        void DeleteCategory(int categoryId);

        // Items data access
        Task<List<Item>> GetItems();
        Task<Item> GetItem(int itemId);
        Task<List<Item>> GetUsersItems(string userId);
        Task<Item> AddItem(Item item);
        void DeleteItem(int itemId);
    }
}
