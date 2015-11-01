namespace Logs.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Log
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
    }
}
