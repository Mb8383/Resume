﻿using Resume.Domain.Models.Entities.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.RepositoryInterface
{
    public interface IExperinceRepository
    {
     public List<Experience> Experience();
    }
}
