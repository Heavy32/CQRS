using System.Threading.Tasks;

namespace Business
{
    public interface IRequestHandler<TRequest, TResponse>
    {
        public Task<TResponse> Handle(TRequest request);
    }
}
