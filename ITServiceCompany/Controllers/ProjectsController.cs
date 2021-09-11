namespace ITServiceCompany.Controllers
{
    using ITServiceCompany.Services.Projects;
    using Microsoft.AspNetCore.Mvc;

    public class ProjectsController : Controller
    {
        private readonly IProjectService service;

        public ProjectsController(IProjectService service)
        {
            this.service = service;
        }
        public IActionResult Project()
        {
            var viewModel = this.service.GetProjects();

            return View(viewModel);
        }
      
    }
}
