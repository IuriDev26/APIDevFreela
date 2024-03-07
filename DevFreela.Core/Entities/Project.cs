using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities {
    public class Project: BaseEntity {
        public Project(string title, string description, int clientId, int freelancerId, decimal totalCost) {
            Title = title;
            Description = description;
            ClientId = clientId;
            FreelancerId = freelancerId;
            TotalCost = totalCost;
            CreatedAt = DateTime.Now ;
            Comments = new List<ProjectComment>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int ClientId { get; private set; }
        public int FreelancerId { get; private set; }

        public decimal TotalCost { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime? StartAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }

        public ProjectStatusEnum Status {  get; private set; }

        public List<ProjectComment> Comments { get; private set; }

        public void CancelProject() {
            if (Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.Suspended) {
                Status = ProjectStatusEnum.Cancelled;
            }
        }

        public void FinishProject() {
            if (Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.Suspended ) {
                Status = ProjectStatusEnum.Finished;
            }
        }

        public void StartProject() {
            if (Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.Suspended) {
                Status = ProjectStatusEnum.InProgress;
            }
        }

    }
}
