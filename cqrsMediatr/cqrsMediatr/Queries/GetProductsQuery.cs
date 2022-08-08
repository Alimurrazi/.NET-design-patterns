using cqrsMediatr.Models;
using MediatR;

namespace cqrsMediatr.Queries
{
    public record GetProductsQuery(): IRequest<IEnumerable<Product>>;
}
