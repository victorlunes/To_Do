using System.ComponentModel.DataAnnotations;

namespace To_Do.Models
{
    public class TaskModel
    {
        [Key]
        public int Id { get; set; }

        public string TaskTitle { get; set; }

        public string DescriptionTask { get; set; }

        public bool Active { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now.ToLocalTime();

        public DateTime ChangeDate { get; set; } = DateTime.Now.ToLocalTime();
    }
}
