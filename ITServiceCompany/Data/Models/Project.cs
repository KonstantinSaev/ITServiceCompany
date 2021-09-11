namespace ITServiceCompany.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static ITServiceCompany.Data.DataConstants;

    public class Project
    {
        public int Id { get; set; }

        [Required]
        [MinLength(ProjectNameMinLength)]
        public string Name { get; set; }

        public string ImgUrl { get; set; }
    }
}
