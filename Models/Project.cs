using System.ComponentModel.DataAnnotations;

namespace Emptyp.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string GithubUrl { get; set; }
    }
}


//using System.ComponentModel.DataAnnotations;

//namespace Emptyp.Models
//{
//    public class project
//    {
//        [Key]
//        public int Id { get; set; }
//        [Required]
//        public string Title { get; set; }
//        public string Description { get; set; }
//        public string ImageUrl { get; set; }
//        public string GithubUrl { get; set; }

//    }
//}
