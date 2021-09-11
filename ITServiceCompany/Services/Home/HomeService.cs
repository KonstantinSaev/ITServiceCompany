namespace ITServiceCompany.Services.Home
{
    using ITServiceCompany.Data;
    using ITServiceCompany.Models;
    using ITServiceCompany.Services.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class HomeService : IHomeService
    {
        private readonly ITServiceCompanyDbContext data;

        public HomeService(ITServiceCompanyDbContext data)
        {
            this.data = data;
        }
        public IEnumerable<HomeServiceModel> GetProjects()
        {
            return this.data.Projects.Take(4).Select(x => new HomeServiceModel
            {
                ProjectName = x.Name,
                ProjectImgUrl = x.ImgUrl,
            }).ToList();
        }
    }
}
