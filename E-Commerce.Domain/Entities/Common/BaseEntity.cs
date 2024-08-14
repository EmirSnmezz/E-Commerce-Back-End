using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid ID { get; set; } // Guid benzersiz ve tekrar şansı olmayan Id'lerdir. Database'deki karşılığı Uniq Identyfier'dır
        public DateTime CreatedDate { get; set; }
    }
}
