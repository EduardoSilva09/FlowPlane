using FlowPlane.Application.ViewModels;
using FlowPlane.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FlowPlane.Application.Queries.GetActivityById
{
    public class GetActivityByIdQueryHandle : IRequestHandler<GetActivityByIdQuery, ActivityViewModel>
    {
        private readonly FlowPlaneDBContext _dbContext;
        public GetActivityByIdQueryHandle(FlowPlaneDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActivityViewModel> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
        {
            var activity = await _dbContext.Activities.SingleOrDefaultAsync(a => a.Id == request.Id);

            if (activity == null)
            {
                return null;
            }

            return new ActivityViewModel(
                activity.Title,
                activity.Description,
                activity.IdClient,
                activity.EndTime,
                activity.StartTime,
                activity.RepeatPeriod,
                activity.DaysOfWeek,
                activity.Status
            );
        }
    }
}