namespace ITServiceCompany.Services.Workers
{
    using ITServiceCompany.Data;
    using ITServiceCompany.Services.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class WorkerService : IWorkerService
    {
        private readonly ITServiceCompanyDbContext data;

        public WorkerService(ITServiceCompanyDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<WorkersServiceModel> GetWorkers()
        {
            return this.data.Workers.Select(x => new WorkersServiceModel
            {
                Name = x.Name,
                ImgUrl = x.ImgUrl,
                Description = x.Description,

            }).ToList();
        }
    }
}
