using cqrsMediatr.Models;
using MediatR;

namespace cqrsMediatr.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
