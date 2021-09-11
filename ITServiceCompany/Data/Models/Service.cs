namespace ITServiceCompany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static ITServiceCompany.Data.DataConstants;

    public class Service
    {

        public Service()
        {
            this.Workers = new HashSet<Worker>();
        }
        
        public int Id { get; set; }

        [Required]
        [MinLength(ServiceNameMinLength)]
        [MaxLength(ServiceNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ServiceDescriptionMinLength)]
        public string Description { get; set; }

        public ICollection<Worker> Workers { get; set; }

    }
}
