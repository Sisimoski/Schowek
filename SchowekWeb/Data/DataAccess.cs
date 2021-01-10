using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchowekWeb.Models;

namespace SchowekWeb.Data
{
    public class DataAccess : IDataAccess
    {
        private readonly ApplicationDbContext _dbContext;

        public DataAccess(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // ------------- Categories -------------

        //GET All Categories
        public async Task<List<Category>> GetCategories()
        {
            return await _dbContext.Categories.ToListAsync();
        }

        //GET Category by CategoryID
        public async Task<Category> GetCategory(int categoryId)
        {
            var result = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
            return result;
        }

        // GET User's Category by UserID
        public async Task<List<Category>> GetUsersCategory(string userId)
        {
            var result = await _dbContext.Categories.Where(c => c.UserId == userId).ToListAsync();
            return result;
        }

        //INSERT Category
        public async Task<Category> AddCategory(Category category)
        {
            var result = await _dbContext.Categories.AddAsync(category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        //UPDATE Category
        public async Task<Category> UpdateCategory(Category category)
        {
            var result = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == category.Id);

            if (result != null)
            {
                result.CategoryName = category.CategoryName;
                result.Icon = category.Icon;

                await _dbContext.SaveChangesAsync();
            }

            return result;
        }

        //DELETE Category
        public async void DeleteCategory(int categoryId)
        {
            var result = await _dbContext.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
            if (result != null)
            {
                _dbContext.Categories.Remove(result);
                await _dbContext.SaveChangesAsync();
            }
        }

        // ------------- Items -------------

        public async Task<List<Item>> GetItems()
        {
            return await _dbContext.Items.ToListAsync();
        }

        public async Task<Item> GetItem(int itemId)
        {
            var result = await _dbContext.Items.FirstOrDefaultAsync(i => i.Id == itemId);
            return result;
        }

        public async Task<Item> AddItem(Item item)
        {
            var result = await _dbContext.Items.AddAsync(item);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async void DeleteItem(int itemId)
        {
            var result = await _dbContext.Items.FirstOrDefaultAsync(i => i.Id == itemId);
            if (result != null)
            {
                _dbContext.Items.Remove(result);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
