namespace ITServiceCompany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static ITServiceCompany.Data.DataConstants;

    public class Worker
    {

        public Worker()
        {
            this.Services = new HashSet<Service>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(WorkerNameMinLength)]
        [MaxLength(WorkerNameMaxLength)]
        public string Name { get; set; }


        [Required]
        [MinLength(WorkerDescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        [Url]
        public string ImgUrl { get; set; }

        public ICollection<Service> Services { get; set; }
    }
}
