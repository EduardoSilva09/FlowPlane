using FlowPlane.Core.Entities;
using FlowPlane.Core.Repositories;

namespace FlowPlane.Application.Commands.CreateActivity
{
    public class CreateActivityCommandHandler
    {
        private readonly IActivityRepository _ActivityRepository;
        public CreateActivityCommandHandler(IActivityRepository ActivityRepository)
        {
            _ActivityRepository = ActivityRepository;
        }

        public async Task<int> Handle(CreateActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = new Activity(
                request.Title,
                request.Description,
                request.IdClient,
                request.EndTime,
                request.StartTime,
                request.RepeatPeriod,
                request.DaysOfWeek);

            await _ActivityRepository.AddActivityAsync(activity);

            return activity.Id;
        }
    }
}