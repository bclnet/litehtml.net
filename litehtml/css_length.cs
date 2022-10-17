using System.Diagnostics;
using static litehtml.html;
using static litehtml.types;

namespace litehtml
{
    [DebuggerDisplay("{_value}:{_predef}{_units}")]
    public struct css_length
    {
        float m_value; //:union
        int m_predef; //:union
        css_units m_units;
        bool m_is_predefined;

        public css_length(ref css_length val)
        {
            if (val.is_predefined)
            {
                m_value = 0;
                m_predef = val.m_predef;
            }
            else
            {
                m_value = val.m_value;
                m_predef = 0;
            }
            m_units = val.m_units;
            m_is_predefined = val.m_is_predefined;
        }

        public css_length(float val)
        {
            m_value = val;
            m_predef = 0;
            m_units = css_units.px;
            m_is_predefined = false;
        }

        public bool is_predefined
            => m_is_predefined;

        public int predef
        {
            get => m_is_predefined ? m_predef : 0;
            set { m_predef = value; m_is_predefined = true; }
        }

        public void set_value(float val, css_units units)
        {
            m_value = val;
            m_is_predefined = false;
            m_units = units;
        }

        public float val
            => !m_is_predefined ? m_value : 0;

        public css_units units
            => m_units;

        public int calc_percent(int width)
            => !is_predefined
            ? units == css_units.percentage
                ? (int)((double)width * (double)m_value / 100.0)
                : (int)val
            : 0;

        public void fromString(string str, string predefs = "", int defValue = 0)
        {
            // TODO: Make support for calc
            if (str.StartsWith("calc"))
            {
                m_is_predefined = true;
                m_predef = 0;
                return;
            }

            var predef = value_index(str, predefs, -1);
            if (predef >= 0)
            {
                m_is_predefined = true;
                m_predef = predef;
            }
            else
            {
                m_is_predefined = false;

                int i = 0;
                foreach (var chr in str)
                {
                    i++;
                    if (t_isdigit(chr) || chr == '.' || chr == '+' || chr == '-')
                        continue;
                }
                var num = str[..i];
                var un = str[i..];

                if (num.Length != 0)
                {
                    m_value = (float)strtod.t_strtod(num, null);
                    m_units = (css_units)value_index(un, css_units_strings, (int)css_units.none);
                }
                else
                {
                    // not a number so it is predefined
                    m_is_predefined = true;
                    m_predef = defValue;
                }
            }
        }

        public override string ToString()
            => m_is_predefined
                ? $"def({m_predef})"
                : $"{m_value}{{{html.index_value((int)m_units, css_units_strings)}}}";
    }
}
