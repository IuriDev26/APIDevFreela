﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities {
    public class User: BaseEntity {
        public User(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now;
            Active = true;
            Skills = new List<UserSkill>();
            OwnProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
        }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public bool Active { get; private set; }

        public List<UserSkill> Skills { get; private set; }

        public List<Project> OwnProjects { get; private set; }

        public List<Project> FreelanceProjects { get; private set; }


    }
}
