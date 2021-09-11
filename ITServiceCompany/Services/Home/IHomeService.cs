namespace ITServiceCompany.Services.Home
{
    using ITServiceCompany.Services.Models;
    using System.Collections.Generic;
    public interface IHomeService
    {
        public IEnumerable<HomeServiceModel> GetProjects();
    }
}
