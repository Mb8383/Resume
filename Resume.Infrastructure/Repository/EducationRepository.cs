using Microsoft.EntityFrameworkCore;
using Resume.Domain.Models.Entities.Educaties;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Infrastructure.Repository
{
    public class EducationRepository:IEducationRepository
    {
        private RsumeDbContext _context;
        public EducationRepository(RsumeDbContext context)
        {
            _context = context;
        }

        public List<Educaties> Educaties()
        {
         return  _context.Educaties.ToList();
        }
    }
}
