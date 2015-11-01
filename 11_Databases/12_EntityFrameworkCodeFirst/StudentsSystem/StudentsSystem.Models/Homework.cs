﻿namespace StudentsSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Homework
    {
        public int Id { get; set; }

        [MaxLength(300)]
        public string Content { get; set; }

        [Required]
        public DateTime TimeSent { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
