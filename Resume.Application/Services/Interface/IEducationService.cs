using Resume.Presentation.Models.Entities.Educaties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Interface
{
    public interface IEducationService
    {
        Task CreatAnEducaties(Educaties educaties);
        Task DeleteAnEducaties(int id);
        Task EditeAnEducaties(int id);
        Task<Educaties> GetbyIDAnEducaties(int id);
        Task<List<Educaties>> GetAllAnEducaties();
    }
}
