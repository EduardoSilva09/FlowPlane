using FlowPlane.Application.ViewModels;
using MediatR;

namespace FlowPlane.Application.Queries.GetActivityById
{
    public class GetActivityByIdQuery : IRequest<ActivityViewModel>
    {
        public GetActivityByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}