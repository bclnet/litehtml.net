namespace litehtml
{
    public struct css_border
    {
        public css_length width;
        public border_style style;
        public web_color color;

        public css_border(ref css_border val)
        {
            width = val.width;
            style = val.style;
            color = val.color;
        }

        public override string ToString()
            => $"{width}/{html.index_value((int)style, types.border_style_strings)}/{color}";
    }

    public struct border
    {
        public int width;
        public border_style style;
        public web_color color;

        public border(ref border val)
        {
            width = val.width;
            style = val.style;
            color = val.color;
        }

        public border(ref css_border val)
        {
            width = (int)val.width.val;
            style = val.style;
            color = val.color;
        }
    }

    public struct border_radiuses
    {
        public int top_left_x;
        public int top_left_y;
#if H3ML
        public int top_left_z;
#endif

        public int top_right_x;
        public int top_right_y;
#if H3ML
        public int top_right_z;
#endif

        public int bottom_right_x;
        public int bottom_right_y;
#if H3ML
        public int bottom_right_z;
#endif

        public int bottom_left_x;
        public int bottom_left_y;
#if H3ML
        public int bottom_left_z;
#endif

        public border_radiuses(ref border_radiuses val)
        {
            top_left_x = val.top_left_x;
            top_left_y = val.top_left_y;
            top_right_x = val.top_right_x;
            top_right_y = val.top_right_y;
            bottom_right_x = val.bottom_right_x;
            bottom_right_y = val.bottom_right_y;
            bottom_left_x = val.bottom_left_x;
            bottom_left_y = val.bottom_left_y;
#if H3ML
            top_left_z = val.top_left_z;
            top_right_z = val.top_right_z;
            bottom_right_z = val.bottom_right_z;
            bottom_left_z = val.bottom_left_z;
#endif
        }

        public static border_radiuses operator +(border_radiuses t, margins mg)
        {
            t.top_left_x += mg.left;
            t.top_left_y += mg.top;
            t.top_right_x += mg.right;
            t.top_right_y += mg.top;
            t.bottom_right_x += mg.right;
            t.bottom_right_y += mg.bottom;
            t.bottom_left_x += mg.left;
            t.bottom_left_y += mg.bottom;
#if H3ML
            t.top_left_z += mg.front;
            t.top_right_z += mg.front;
            t.bottom_right_z += mg.back;
            t.bottom_left_z += mg.back;
#endif
            t.fix_values();
            return t;
        }

        public static border_radiuses operator -(border_radiuses t, margins mg)
        {
            t.top_left_x -= mg.left;
            t.top_left_y -= mg.top;
            t.top_right_x -= mg.right;
            t.top_right_y -= mg.top;
            t.bottom_right_x -= mg.right;
            t.bottom_right_y -= mg.bottom;
            t.bottom_left_x -= mg.left;
            t.bottom_left_y -= mg.bottom;
#if H3ML
            t.top_left_z -= mg.front;
            t.top_right_z -= mg.front;
            t.bottom_right_z -= mg.back;
            t.bottom_left_z -= mg.back;
#endif
            t.fix_values();
            return t;
        }

        void fix_values()
        {
            if (top_left_x < 0) top_left_x = 0;
            if (top_left_y < 0) top_left_y = 0;
            if (top_right_x < 0) top_right_x = 0;
            if (top_right_y < 0) top_right_y = 0;
            if (bottom_right_x < 0) bottom_right_x = 0;
            if (bottom_right_y < 0) bottom_right_y = 0;
            if (bottom_left_x < 0) bottom_left_x = 0;
            if (bottom_left_y < 0) bottom_left_y = 0;
#if H3ML
            if (top_left_z < 0) top_left_z = 0;
            if (top_right_z < 0) top_right_z = 0;
            if (bottom_right_z < 0) bottom_right_z = 0;
            if (bottom_left_z < 0) bottom_left_z = 0;
#endif
        }
    }

    public struct css_border_radius
    {
        public css_length top_left_x;
        public css_length top_left_y;
#if H3ML
        public css_length top_left_z;
#endif

        public css_length top_right_x;
        public css_length top_right_y;
#if H3ML
        public css_length top_right_z;
#endif

        public css_length bottom_right_x;
        public css_length bottom_right_y;
#if H3ML
        public css_length bottom_right_z;
#endif

        public css_length bottom_left_x;
        public css_length bottom_left_y;
#if H3ML
        public css_length bottom_left_z;
#endif

        public css_border_radius(ref css_border_radius val)
        {
            top_left_x = val.top_left_x;
            top_left_y = val.top_left_y;
            top_right_x = val.top_right_x;
            top_right_y = val.top_right_y;
            bottom_left_x = val.bottom_left_x;
            bottom_left_y = val.bottom_left_y;
            bottom_right_x = val.bottom_right_x;
            bottom_right_y = val.bottom_right_y;
#if H3ML
            top_left_z = val.top_left_z;
            top_right_z = val.top_right_z;
            bottom_left_z = val.bottom_left_z;
            bottom_right_z = val.bottom_right_z;
#endif
        }

        public border_radiuses calc_percents(ref size sz)
        {
            border_radiuses ret;
            ret.bottom_left_x = bottom_left_x.calc_percent(sz.width);
            ret.bottom_left_y = bottom_left_y.calc_percent(sz.height);
            ret.top_left_x = top_left_x.calc_percent(sz.width);
            ret.top_left_y = top_left_y.calc_percent(sz.height);
            ret.top_right_x = top_right_x.calc_percent(sz.width);
            ret.top_right_y = top_right_y.calc_percent(sz.height);
            ret.bottom_right_x = bottom_right_x.calc_percent(sz.width);
            ret.bottom_right_y = bottom_right_y.calc_percent(sz.height);
#if H3ML
            ret.bottom_left_z = bottom_left_z.calc_percent(sz.depth);
            ret.top_left_z = top_left_z.calc_percent(sz.depth);
            ret.top_right_z = top_right_z.calc_percent(sz.depth);
            ret.bottom_right_z = bottom_right_z.calc_percent(sz.depth);
#endif
            return ret;
        }
    }

    public struct css_borders
    {
        public css_border left;
        public css_border top;
        public css_border right;
        public css_border bottom;
#if H3ML
        public css_border front;
        public css_border back;
#endif
        public css_border_radius radius;

        public bool is_visible
            => left.width.val != 0 || right.width.val != 0 || top.width.val != 0 || bottom.width.val != 0
#if H3ML
            || front.width.val != 0 || back.width.val != 0
#endif
            ;

        public css_borders(ref css_borders val)
        {
            left = val.left;
            right = val.right;
            top = val.top;
            bottom = val.bottom;
#if H3ML
            front = val.front;
            back = val.back;
#endif
            radius = val.radius;
        }

        public override string ToString()
            => $"left: {left}, top: {top}, right: {right}, bottom: {bottom}"
#if H3ML
            + $", front: {front}, back: {back}"
#endif
            ;
    }

    public struct borders
    {
        public border left;
        public border top;
        public border right;
        public border bottom;
#if H3ML
        public border front;
        public border back;
#endif
        public border_radiuses radius;

        public borders(ref borders val)
        {
            left = val.left;
            right = val.right;
            top = val.top;
            bottom = val.bottom;
#if H3ML
            front = val.front;
            back = val.back;
#endif
            radius = val.radius;
        }

        public borders(ref css_borders val)
        {
            left = new border(ref val.left);
            right = new border(ref val.right);
            top = new border(ref val.top);
            bottom = new border(ref val.bottom);
#if H3ML
            front = new border(ref val.front);
            back = new border(ref val.back);
#endif
            radius = default;
        }

        public bool is_visible
            => left.width != 0 || right.width != 0 || top.width != 0 || bottom.width != 0
#if H3ML
            || front.width != 0 || back.width != 0
#endif
            ;
    }
}
