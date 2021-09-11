namespace ITServiceCompany.Services.Projects
{
    using ITServiceCompany.Data;
    using ITServiceCompany.Services.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ProjectService : IProjectService
    {
        private readonly ITServiceCompanyDbContext data;

        public ProjectService(ITServiceCompanyDbContext data)
        {
            this.data = data;
        }
        public IEnumerable<ProjectsServiceModel> GetProjects()
        {
            return this.data.Projects.Select(x => new ProjectsServiceModel
            {
                Name = x.Name,
                ImgUrl = x.ImgUrl,

            }).ToList();
        }
    }
}
