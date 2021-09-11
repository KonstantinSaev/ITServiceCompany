namespace ITServiceCompany.Services.Projects
{
    using ITServiceCompany.Services.Models;
    using System.Collections.Generic;

    public interface IProjectService
    {
        public IEnumerable<ProjectsServiceModel> GetProjects();
    }
}
