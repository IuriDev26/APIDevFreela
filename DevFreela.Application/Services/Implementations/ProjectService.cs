using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure;
using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations {
    public class ProjectService : IProjectService {

        private readonly DevFreelaDbContext _dbContext;

        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(NewProjectInputModel inputModel) {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);

            _dbContext.Projects.Add(project);
            return project.Id;

        }

        public void CreateComment(int id, CreateCommentInputModel createdComment) {

            _dbContext.Comments.Add(new ProjectComment(createdComment.content, createdComment.userId, createdComment.projectId));

        }

        public void Delete(int id) {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            _dbContext.Projects.Remove(project);

        }

        public void Finish(int id) {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.FinishProject();
        }

        public ProjectDetailsViewModel GetById(int id) {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            return new ProjectDetailsViewModel(project.Title, project.Description, project.CreatedAt);
        }

        public List<ProjectViewModel> GetProjects(string query) {
            return _dbContext.Projects
                .Select(p => new ProjectViewModel(p.Title, p.Description, p.CreatedAt))
                .ToList();
        }

        public void Start(int id) {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.StartProject();
        }

        public void Update(int id, UpdateProjectInputModel updatedProject) {
            throw new NotImplementedException();
        }
    }
}
