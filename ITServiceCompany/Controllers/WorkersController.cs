namespace ITServiceCompany.Controllers
{
    using ITServiceCompany.Services.Workers;
    using Microsoft.AspNetCore.Mvc;

    public class WorkersController : Controller
    {
        private readonly IWorkerService service;

        public WorkersController(IWorkerService service)
        {
            this.service = service;
        }

        public IActionResult OurTeam()
        {
            var viewModel = this.service.GetWorkers();
             
            return View(viewModel);
        }
    }
}
