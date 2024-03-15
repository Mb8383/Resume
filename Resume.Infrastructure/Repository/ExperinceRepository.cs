using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Experience;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
    public class ExperinceRepository : IExperinceRepository
    {
        private RsumeDbContext _context;
        public ExperinceRepository(RsumeDbContext context)
        {
            _context = context;
        }
        public List<Experience> Experience()
        {
            return _context.Experience.ToList();
        }
    }
}
