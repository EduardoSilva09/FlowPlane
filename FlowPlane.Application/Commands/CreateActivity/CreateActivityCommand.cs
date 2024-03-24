using FlowPlane.Core.Enums;
using MediatR;

namespace FlowPlane.Application.Commands.CreateActivity
{
    public class CreateActivityCommand : IRequest<int>
    {
        public required string Title { get; set; }
        public int IdClient { get; private set; }
        public required string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RepeatPeriodEnum RepeatPeriod { get; set; }
        public DayOfWeek[] DaysOfWeek { get; set; } = [];
    }
}