using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations {
    public class SkillService : ISkillService {

        private readonly DevFreelaDbContext _dbContext;

        public SkillService(DevFreelaDbContext dbContext) { 
            _dbContext = dbContext;
        
        }
        
        public List<SkillViewModel> GetAll() {
            return _dbContext.Skills.Select(s => new SkillViewModel(s.Description, s.CreatedAt)).ToList();
        }
    }
}
