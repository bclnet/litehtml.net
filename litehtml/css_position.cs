namespace litehtml
{
    public struct css_position
    {
        public css_length x;
        public css_length y;
#if H3ML
        public css_length z;
#endif
        public css_length width;
        public css_length height;
#if H3ML
        public css_length depth;
#endif

        public css_position(ref css_position val)
        {
            x = val.x;
            y = val.y;
            width = val.width;
            height = val.height;
#if H3ML
            z = val.z;
            depth = val.depth;
#endif
        }
    }
}
