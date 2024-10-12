using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.BusinessLogicLayer.Dtos
{
    public class AddProductDto
    {
        public AddProductDto()
        {
            UploadedFileDtos = new HashSet<UploadedFileDto>();
        }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public ICollection<UploadedFileDto> UploadedFileDtos { get; set; }
    }
}
