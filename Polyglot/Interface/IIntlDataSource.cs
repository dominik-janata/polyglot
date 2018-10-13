using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace Polyglot.Interface
{
    public interface IIntlDataSource
    {
        Task<IDictionary<CultureInfo, IDictionary<string, string>>> LoadAsync();
    }
}