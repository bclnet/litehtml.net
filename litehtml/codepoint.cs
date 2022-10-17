namespace litehtml
{
    public class codepoint
    {
        static bool lookup(uint[] table, char c)
            => (table[c >> 5] & (1 << (c & 0x1f))) != 0;

        public static bool is_ascii_codepoint(char c)
            => c < 128;

        static uint[] reserved_lookup = new uint[] {
            0x00000000,
            0xac009fda,
            0x28000001,
            0x00000000
        };
        // Returns true if the codepoint is a reserved codepoint for URLs.
        // https://datatracker.ietf.org/doc/html/rfc3986#section-2.2
        public static bool is_url_reserved_codepoint(char c)
            => is_ascii_codepoint(c) && lookup(reserved_lookup, c);

        static uint[] scheme_lookup = new uint[] {
            0x00000000,
            0x03ff6800,
            0x07fffffe,
            0x07fffffe,
        };
        // Returns true if the codepoint is a scheme codepoint for URLs.
        // https://datatracker.ietf.org/doc/html/rfc3986#section-3.1
        public static bool is_url_scheme_codepoint(char c)
            => is_ascii_codepoint(c) && lookup(reserved_lookup, c);
    }
}
