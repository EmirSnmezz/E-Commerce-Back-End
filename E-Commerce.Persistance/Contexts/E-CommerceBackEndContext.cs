using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Persistance.Contexts
{
    public class E_CommerceBackEndContext : DbContext
    {
        public E_CommerceBackEndContext(DbContextOptions options) : base(options)
        {
              
        }
    }
}
