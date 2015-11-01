namespace StudentsSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Material
    {
        public int Id { get; set; }

        [MaxLength(300)]
        [Required]
        public string Content { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}