using ITServiceCompany.Data;
using ITServiceCompany.Services.Models;
namespace ITServiceCompany.Services.Service
{
    using System.Collections.Generic;
    using System.Linq;

    public class ServiceService : IServiceService
    {
        private readonly ITServiceCompanyDbContext data;

        public ServiceService(ITServiceCompanyDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<ServicesServiceModel> GetServices()
        {
            return this.data.Services.Select(x => new ServicesServiceModel
            {
                Name = x.Name,
                Description = x.Description,

            }).ToList();
        }
    }
}
