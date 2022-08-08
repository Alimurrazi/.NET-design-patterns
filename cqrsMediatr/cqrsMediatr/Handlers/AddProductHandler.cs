using cqrsMediatr.Commands;
using cqrsMediatr.Data;
using MediatR;

namespace cqrsMediatr.Handlers
{
    public class AddProductHandler: IRequestHandler<AddProductCommand, Unit>
    {
        private readonly FakeDataStore _fakeDataStore;
        public AddProductHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }
        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.AddProduct(request.Product);
            return Unit.Value;
        }
    }
}
