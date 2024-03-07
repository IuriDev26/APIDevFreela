using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.Entities {
    public class ProjectComment: BaseEntity {
        public ProjectComment(string content, int userId, int projectId) {
            Content = content;
            UserId = userId;
            ProjectId = projectId;
            CreatedAt = DateTime.Now;
        }

        public string Content { get; private set; }

        public int UserId { get; private set; }
        public int ProjectId { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }

}
