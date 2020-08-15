using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Data
{
    public class GettingApplicationDbContext
    {
        private readonly ApplicationDbContext _context;
        public GettingApplicationDbContext(ApplicationDbContext context)
        {
            _context = context;
        }
        public ApplicationDbContext GetApplicatonDbContext()
        {
            return _context;
        }
    }
}
