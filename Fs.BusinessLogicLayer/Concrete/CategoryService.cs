using Fs.BusinessLogicLayer.Abstract;
using Fs.DataAccessLayer.EntityFrameworkCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.BusinessLogicLayer.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IDictionary<int, string>> GetCategoryDictionaryAsync()
        {
            return await _categoryRepository.GetDictionaryAsync(x => x.Id, x => x.Value);   
        }

      
    }
}
