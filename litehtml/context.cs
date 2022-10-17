namespace litehtml
{
    public class context
    {
        css m_master_css = new();

        public void load_master_stylesheet(string str)
        {
            master_css.parse_stylesheet(str, null, null, null); //:TODO shared_ptr<>
            master_css.sort_selectors();
        }

        public css master_css => m_master_css;
    }
}
