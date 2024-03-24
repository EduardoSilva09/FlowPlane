using FlowPlane.Core.Enums;

namespace FlowPlane.Core.Entities
{
    public class Activity : BaseEntity
    {
        public Activity(string title, string description, int idClient, DateTime endTime, DateTime startTime, RepeatPeriodEnum repeatPeriod, DayOfWeek[] daysOfWeek)
        {
            Title = title;
            IdClient = idClient;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            RepeatPeriod = repeatPeriod;
            DaysOfWeek = daysOfWeek;
            CreatedAt = DateTime.Now;
            Status = ActivityStatusEnum.Created;
        }
        public string Title { get; set; }
        public int IdClient { get; private set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RepeatPeriodEnum RepeatPeriod { get; set; }
        public ActivityStatusEnum Status { get; private set; }
        public DayOfWeek[] DaysOfWeek { get; set; } = [];
        public User? Client { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
    }
}