using System.Globalization;

namespace Polyglot.Interface
{
    public interface IIntlProvider
    {
        CultureInfo CurrentCulture { get; set; }
        string this[string key] { get; }
    }
}
