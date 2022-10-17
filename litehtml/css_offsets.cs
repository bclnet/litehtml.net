namespace litehtml
{
    public struct css_offsets
    {
        public css_length left;
        public css_length top;
        public css_length right;
        public css_length bottom;
#if H3ML
        public css_length front;
        public css_length back;
#endif

        public css_offsets(ref css_offsets val)
        {
            left = val.left;
            top = val.top;
            right = val.right;
            bottom = val.bottom;
#if H3ML
            front = val.front;
            back = val.back;
#endif
        }

        public override string ToString()
            => $"left: {left}, top: {top}, right: {right}, bottom: {bottom}"
#if H3ML
            + $", front: {front}, back: {back}"
#endif
            ;
    }
}
