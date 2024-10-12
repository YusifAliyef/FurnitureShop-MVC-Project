using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fs.Entity.Commons
{
    public class EditedBaseEntity:BaseEntity
    {
        public int? UpdatedId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedId { get; set; }

    }
}
