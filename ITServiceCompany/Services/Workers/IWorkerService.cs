namespace ITServiceCompany.Services.Workers
{
    using ITServiceCompany.Services.Models;
    using System.Collections.Generic;

    public interface IWorkerService
    {
        public IEnumerable<WorkersServiceModel> GetWorkers();
    }
}
