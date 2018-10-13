using System.Collections.Generic;
using System.Globalization;
using Polyglot.Interface;

namespace Polyglot.IntlProviders
{
    public class InMemoryIntlProvider : IIntlProvider
    {
        private readonly IIntlDataSource dataSource;
        private IDictionary<CultureInfo, IDictionary<string, string>> data;

        public InMemoryIntlProvider(IIntlDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        private bool IsInitialized
        {
            get
            {
                return this.data != null;
            }
        }

        public CultureInfo CurrentCulture { get; set; }

        public string this[string key]
        {
            get
            {
                if (!this.IsInitialized)
                {
                    this.data = this.dataSource.Load();
                }

                return this.data[this.CurrentCulture][key];
            }
        }
    }
}
