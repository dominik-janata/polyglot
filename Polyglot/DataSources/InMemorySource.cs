using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Polyglot.Interface;

namespace Polyglot.DataSources
{
    public class InMemorySource : IIntlDataSource
    {
        private IDictionary<CultureInfo, IDictionary<string, string>> dictionary;

        public InMemorySource(IDictionary<CultureInfo, IDictionary<string, string>> dictionary)
        {
            this.dictionary = dictionary;
        }

        public Task<IDictionary<CultureInfo, IDictionary<string, string>>> LoadAsync()
        {
            return Task.FromResult(this.dictionary);
        }
    }
}
