using System.Collections.Generic;

namespace litehtml
{
    public class background
    {
        public string m_image;
        public string m_baseurl;
        public web_color m_color;
        public background_attachment m_attachment;
        public css_position m_position;
        public background_repeat m_repeat;
        public background_box m_clip;
        public background_box m_origin;
        public css_border_radius m_radius;

        public background()
        {
            m_attachment = background_attachment.scroll;
            m_repeat = background_repeat.repeat;
            m_clip = background_box.border;
            m_origin = background_box.padding;
            m_color.alpha = 0;
            m_color.red = 0;
            m_color.green = 0;
            m_color.blue = 0;
        }

        public background(ref background val)
        {
            m_image = val.m_image;
            m_baseurl = val.m_baseurl;
            m_color = val.m_color;
            m_attachment = val.m_attachment;
            m_position = val.m_position;
            m_repeat = val.m_repeat;
            m_clip = val.m_clip;
            m_origin = val.m_origin;
            m_radius = val.m_radius;
        }
    }

    public class background_paint
    {
        public string image;
        public string baseurl;
        public Dictionary<string, string> attrs;
        public background_attachment attachment;
        public background_repeat repeat;
        public web_color color;
        public position clip_box;
        public position origin_box;
        public position border_box;
        public border_radiuses border_radius;
        public size image_size;
        public point position;
        public bool is_root;

        public background_paint()
        {
            color = new(0, 0, 0, 0);
            position = point.@default;
            attachment = background_attachment.scroll;
            repeat = background_repeat.repeat;
            is_root = false;
        }

        public background_paint(ref background_paint val)
        {
            image = val.image;
            baseurl = val.baseurl;
            attachment = val.attachment;
            repeat = val.repeat;
            color = val.color;
            clip_box = val.clip_box;
            origin_box = val.origin_box;
            border_box = val.border_box;
            border_radius = val.border_radius;
            image_size = val.image_size;
            position = val.position;
            is_root = val.is_root;
        }

        public void assign(ref background val)
        {
            attachment = val.m_attachment;
            baseurl = val.m_baseurl;
            image = val.m_image;
            repeat = val.m_repeat;
            color = val.m_color;
        }
    }
}