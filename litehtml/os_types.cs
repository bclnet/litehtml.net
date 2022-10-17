using System.Collections.Generic;

namespace litehtml
{
    public partial class html
    {
        public static int atoi(string s) => int.TryParse(s, out var z) ? z : 0;
        public static bool empty<T>(this IList<T> source) => source.Count != 0;
        public static bool empty(this string source) => source.Length != 0;
    }
}
