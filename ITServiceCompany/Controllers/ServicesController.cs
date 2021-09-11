namespace ITServiceCompany.Controllers
{
    using ITServiceCompany.Services.Service;
    using Microsoft.AspNetCore.Mvc;

    public class ServicesController : Controller
    {
        private readonly IServiceService service;

        public ServicesController(IServiceService service)
        {
            this.service = service;
        }
        public IActionResult Service() 
        {
            var viewModel = this.service.GetServices();

            return View(viewModel);
        }
    }
}
