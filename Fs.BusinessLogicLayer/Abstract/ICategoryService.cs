using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.BusinessLogicLayer.Abstract
{
    public interface ICategoryService
    {
        public Task<IDictionary<int, string>> GetCategoryDictionaryAsync();
    }
}
