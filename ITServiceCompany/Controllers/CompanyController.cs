namespace ITServiceCompany.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CompanyController : Controller
    {
        public IActionResult ContactUs() => View();

        public IActionResult AboutUs() => View();

        public IActionResult Finish() => View();
    }
}
