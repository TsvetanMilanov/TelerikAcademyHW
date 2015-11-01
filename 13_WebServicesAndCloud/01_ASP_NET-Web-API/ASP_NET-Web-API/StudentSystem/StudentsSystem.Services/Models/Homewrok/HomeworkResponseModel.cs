namespace StudentsSystem.Services.Models.Homewrok
{
    using System;

    public class HomeworkResponseModel
    {
        public int Id { get; set; }

        public string FileUrl { get; set; }

        public DateTime TimeSent { get; set; }
    }
}