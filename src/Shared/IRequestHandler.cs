using System.Threading;
using System.Threading.Tasks;

namespace Shared;

public interface IRequestHandler<TRequest, TResponse>
{
    Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}
