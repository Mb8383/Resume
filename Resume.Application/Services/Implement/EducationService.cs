#region Using
using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.Educaties;
using Resume.Presentation.Models.ResumeDbContext;

namespace Resume.Application.Services.Implement;
#endregion
public class EducationService:IEducationService
{
    #region ctor
    private RsumeDbContext _context;
    public EducationService(RsumeDbContext context)
    {
        _context = context;
    }
    #endregion
    public async Task CreatAnEducaties(Educaties educaties)
    {
      await  _context.AddAsync(educaties);
      await _context.SaveChangesAsync();
       
    }

    public async Task DeleteAnEducaties(int id)
    {
        var ed =await GetbyIDAnEducaties(id);
         _context.Remove(ed);
       await _context.SaveChangesAsync();

    }

    public async Task EditeAnEducaties(int id)
    {
        var ed = await GetbyIDAnEducaties(id);
        _context.Update(ed);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Educaties>> GetAllAnEducaties()
    {
      List<Educaties> educaties=await _context.Educaties.ToListAsync();
        return educaties;
    }

    public async Task<Educaties> GetbyIDAnEducaties(int id)
    {
       var educaties= await _context.Educaties.Where(e=>e.id==id).FirstAsync();
        return educaties;
    }
}
