namespace ITServiceCompany.Services.Service
{
    using ITServiceCompany.Services.Models;
    using System.Collections.Generic;

    public interface IServiceService
    {
        public IEnumerable<ServicesServiceModel> GetServices();
    }
}
