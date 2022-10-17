using System.Globalization;

namespace litehtml
{
    public struct strtod
    {
        public static double t_strtod(string str, string endPtr)
            => double.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out var value) ? value : 0;
    }
}
