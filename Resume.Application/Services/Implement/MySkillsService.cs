using Microsoft.EntityFrameworkCore;
using Resume.Application.Services.Interface;
using Resume.Domain.Models.Entities.MySkills;
using Resume.Domain.RepositoryInterface;

namespace Resume.Application.Services.Implement
{
    public class MySkillsService : IMySkillsService
    {
        public readonly IMySkillsRepository _mySkillsRepository;
        public MySkillsService(IMySkillsRepository mySkillsRepository)
        {
            _mySkillsRepository = mySkillsRepository;
        }
        public List<MySkills> MySkills()
        {
           return _mySkillsRepository.MySkills();
        }
    }
}
