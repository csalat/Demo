using System.Threading;
using System.Threading.Tasks;

namespace Demo.Processors
{
    public interface IProcessor<T>
    {
        Task<T> ExecuteAsync(T payload, CancellationToken token);
    }
}