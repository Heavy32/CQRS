using System.Threading.Tasks;

namespace Business
{
    public interface ICommandHanlder<TCommand>
    {
        public Task Handle(TCommand request);
    }
}
