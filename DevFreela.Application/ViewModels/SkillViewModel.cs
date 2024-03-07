using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels {
    public class SkillViewModel {
        public SkillViewModel(string description, DateTime createdAt) {
            Description = description;
            CreatedAt = createdAt;
        }

        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }


    }
}
