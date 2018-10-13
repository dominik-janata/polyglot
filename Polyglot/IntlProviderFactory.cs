using Polyglot.Interface;
using Polyglot.IntlProviders;

namespace Polyglot
{
    public static class IntlProviderFactory
    {
        private static IIntlProvider singleton;

        public static IIntlProvider Create(IIntlDataSource dataSource)
        {
            if (singleton == null)
            {
                singleton = new InMemoryIntlProvider(dataSource);
            }

            return singleton;
        }
    }
}
