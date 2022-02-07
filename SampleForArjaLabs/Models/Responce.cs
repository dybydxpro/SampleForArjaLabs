using System.ComponentModel.DataAnnotations;

namespace SampleForArjaLabs.Models
{
    public class Responce
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RequestData { get; set; }
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}

