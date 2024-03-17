using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.Experience;
using Resume.Domain.RepositoryInterface;
using Resume.Presentation.Models.ResumeDbContext;
namespace Resume.Application.Services.Implement
{
    public class ExperienceService:IExperienceService
    {
        public readonly IExperinceRepository _experinceRepository;
        public ExperienceService(IExperinceRepository experinceRepository)
        {
            _experinceRepository = experinceRepository;
        }
        public List<Experience> Experience()
        {
           return _experinceRepository.Experience();
        }
    }
}
