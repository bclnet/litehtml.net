namespace litehtml
{
    public struct css_margins
    {
        public css_length left;
        public css_length right;
        public css_length top;
        public css_length bottom;
#if H3ML
        public css_length front;
        public css_length back;
#endif

        public css_margins(ref css_margins val)
        {
            left = val.left;
            right = val.right;
            top = val.top;
            bottom = val.bottom;
#if H3ML
            front = val.front;
            back = val.back;
#endif
        }

        public override string ToString()
            => $"left: {left}, right: {right}, top: {top}, bottom: {bottom}"
#if H3ML
            + $", front: {front}, back: {back}"
#endif
            ;
    }
}
