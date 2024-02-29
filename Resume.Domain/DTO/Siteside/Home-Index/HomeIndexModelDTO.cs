using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.DTO.Siteside.Home_Index
{
	public class HomeIndexModelDTO
	{
		public List<Resume.Domain.Models.Entities.Educaties.Educaties> Educaties { get; set; }
		public List<Resume.Domain.Models.Entities.Experience.Experience> Experiences { get; set; }
		public List<Resume.Domain.Models.Entities.MySkills.MySkills> MySkills { get; set; }

	}
}
