namespace ITServiceCompany.Data.Models
{
    public class WorkerService
    {
        public Worker Worker { get; set; }

        public int WorkerId { get; set; }

        public Service Service { get; set; }

        public int ServiceId { get; set; }
    }
}
