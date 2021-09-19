using System.ComponentModel.DataAnnotations;

namespace ImagierWebDomain.EntityModels
{
    public class Repository
    {
        public int UserId { get; set; }
        [Key]
        public int RepositoryId { get; set; }
        public int RepositoryName { get; set; }
    }
}
