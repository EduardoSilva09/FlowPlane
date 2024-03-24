using MediatR;

namespace FlowPlane.Application.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public required string FullName { get; set; }
        public required string Password { get; set; }
        public string Role { get; set; } = "";
        public required string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}