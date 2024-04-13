using FlowPlane.Core.Enums;

namespace FlowPlane.Application.ViewModels
{
    public class ActivityViewModel
    {
        public ActivityViewModel(
            string title,
            string description,
            int idClient,
            DateTime endTime,
            DateTime startTime,
            RepeatPeriodEnum repeatPeriod,
            DayOfWeek[] daysOfWeek,
            ActivityStatusEnum status)
        {
            Title = title;
            IdClient = idClient;
            Description = description;
            StartTime = startTime;
            EndTime = endTime;
            RepeatPeriod = repeatPeriod;
            DaysOfWeek = daysOfWeek;
            Status = status;
        }
        public string Title { get; set; }
        public int IdClient { get; private set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RepeatPeriodEnum RepeatPeriod { get; set; }
        public ActivityStatusEnum Status { get; private set; }
        public DayOfWeek[] DaysOfWeek { get; set; } = [];

    }
}