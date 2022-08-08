using cqrsMediatr.Models;
using MediatR;

namespace cqrsMediatr.Commands
{
    public record AddProductCommand(Product Product) : IRequest;
}
