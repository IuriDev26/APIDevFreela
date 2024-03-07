using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure {
    public class DevFreelaDbContext {


        public DevFreelaDbContext()
        {
            Projects = new List<Project>{
                new Project("Novo ASP.NET CORE", "Primeio projeto", 1, 1, 3000),
                new Project("Novo ASP.NET CORE", "Primeio projeto", 1, 1, 50000),
                new Project("Novo ASP.NET CORE", "Primeio projeto", 1, 1, 30000)
            };

            Users = new List<User> {
                new User("Iuri", "iuri.iuri@iuri.com", new DateTime(2002,10,20)),
                new User("Genneffer", "Genneffer.iuri@iuri.com", new DateTime(1999,07,05)),
                new User("Genilton", "Genilton.iuri@iuri.com", new DateTime(1970,12,07))
            };

            Skills = new List<Skills> {
                new Skills("C#"),
                new Skills("C++"),
                new Skills("C"),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skills> Skills { get; set; }
        public List<ProjectComment> Comments { get; set; }

        

    }
}
