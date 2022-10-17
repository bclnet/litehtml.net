using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static litehtml.html;
using static litehtml.types;

namespace litehtml
{
    public class css_properties
    {
        element_position m_el_position;
        text_align m_text_align;
        overflow m_overflow;
        white_space m_white_space;
        style_display m_display;
        visibility m_visibility;
        box_sizing m_box_sizing;
        int m_z_index;
        vertical_align m_vertical_align;
        element_float m_float;
        element_clear m_clear;
        css_margins m_css_margins;
        css_margins m_css_padding;
        css_borders m_css_borders;
        css_length m_css_width;
        css_length m_css_height;
#if H3ML
        css_length m_css_depth;
#endif
        css_length m_css_min_width;
        css_length m_css_min_height;
#if H3ML
        css_length m_css_min_depth;
#endif
        css_length m_css_max_width;
        css_length m_css_max_height;
#if H3ML
        css_length m_css_max_depth;
#endif
        css_offsets m_css_offsets;
        css_length m_css_text_indent;
        int m_line_height;
        bool m_lh_predefined;
        list_style_type m_list_style_type;
        list_style_position m_list_style_position;
        background m_bg;
        int m_font_size;
        IntPtr m_font;
        font_metrics m_font_metrics;
        text_transform m_text_transform;
        border_collapse m_border_collapse;
        css_length m_css_border_spacing_x;
        css_length m_css_border_spacing_y;
#if H3ML
        css_length m_css_border_spacing_z;
#endif

        public css_properties()
        {
            //m_el_position = element_position.@static;
            //m_text_align = text_align.left;
            //m_overflow = overflow.visible;
            //m_white_space = white_space.normal;
            m_display = style_display.inline;
            //m_visibility = visibility.visible;
            //m_box_sizing = box_sizing.content_box;
            //m_z_index = 0;
            //m_vertical_align = vertical_align.baseline;
            //m_float = element_float.none;
            //m_clear = element_clear.none;
            //m_css_margins = default;
            //m_css_padding = default;
            //m_css_borders = default;
            //m_css_width = default;
            //m_css_height = default;
            //#if H3ML
            //m_css_depth = default;
            //#endif
            //m_css_min_width = default;
            //m_css_min_height = default;
            //#if H3ML
            //m_css_min_depth = default;
            //#endif
            //m_css_max_width = default;
            //m_css_max_height = default;
            //#if H3ML
            //m_css_max_depth = default;
            //#endif
            //m_css_offsets = default;
            //m_css_text_indent = default;
            //m_line_height = 0;
            //m_lh_predefined = false;
            //m_list_style_type = list_style_type.none;
            m_list_style_position = list_style_position.outside;
            //m_bg = default;
            //m_font_size = 0;
            //m_font = default;
            //m_font_metrics = default;
            //m_text_transform = text_transform.none;
            m_border_collapse = border_collapse.separate;
            //m_css_border_spacing_x = default;
            //m_css_border_spacing_y = default;
            //#if H3ML
            //m_css_border_spacing_z = default;
            //#endif
        }

        static readonly int[][] font_size_table =
        {
                new []{ 9,    9,     9,     9,    11,    14,    18},
                new []{ 9,    9,     9,    10,    12,    15,    20},
                new []{ 9,    9,     9,    11,    13,    17,    22},
                new []{ 9,    9,    10,    12,    14,    18,    24},
                new []{ 9,    9,    10,    13,    16,    20,    26},
                new []{ 9,    9,    11,    14,    17,    21,    28},
                new []{ 9,   10,    12,    15,    17,    23,    30},
                new []{ 9,   10,    13,    16,    18,    24,    32}
        };

        public void parse(element el, document doc)
        {
            parse_font(el, doc);

            m_el_position = (element_position)value_index(el.get_style_property("position", false, "static"), element_position_strings, (int)element_position.@fixed);
            m_text_align = (text_align)value_index(el.get_style_property("text-align", true, "left"), text_align_strings, (int)text_align.left);
            m_overflow = (overflow)value_index(el.get_style_property("overflow", false, "visible"), overflow_strings, (int)overflow.visible);
            m_white_space = (white_space)value_index(el.get_style_property("white-space", true, "normal"), white_space_strings, (int)white_space.normal);
            m_display = (style_display)value_index(el.get_style_property("display", false, "inline"), style_display_strings, (int)style_display.inline);
            m_visibility = (visibility)value_index(el.get_style_property("visibility", true, "visible"), visibility_strings, (int)visibility.visible);
            m_box_sizing = (box_sizing)value_index(el.get_style_property("box-sizing", false, "content-box"), box_sizing_strings, (int)box_sizing.content_box);

            if (m_el_position != element_position.@static)
            {
                var val = el.get_style_property("z-index", false, null);
                if (val != null)
                {
                    m_z_index = t_atoi(val);
                }
            }

            var fl = el.get_style_property("float", false, "none");
            m_float = (element_float)value_index(fl, element_float_strings, (int)element_float.none);


            // https://www.w3.org/TR/CSS22/visuren.html#dis-pos-flo
            if (m_display == style_display.none)
            {
                // 1. If 'display' has the value 'none', then 'position' and 'float' do not apply. In this case, the element
                //    generates no box.
                m_float = element_float.none;
            }
            else
            {
                // 2. Otherwise, if 'position' has the value 'absolute' or 'fixed', the box is absolutely positioned,
                //    the computed value of 'float' is 'none', and display is set according to the table below.
                //    The position of the box will be determined by the 'top', 'right', 'bottom' and 'left' properties
                //    and the box's containing block.
                if (m_el_position == element_position.absolute || m_el_position == element_position.@fixed)
                {
                    m_float = element_float.none;

                    if (m_display == style_display.inline_table)
                    {
                        m_display = style_display.table;
                    }
                    else if (m_display == style_display.inline ||
                               m_display == style_display.table_row_group ||
                               m_display == style_display.table_column ||
                               m_display == style_display.table_column_group ||
                               m_display == style_display.table_header_group ||
                               m_display == style_display.table_footer_group ||
                               m_display == style_display.table_row ||
                               m_display == style_display.table_cell ||
                               m_display == style_display.table_caption ||
                               m_display == style_display.inline_block)
                    {
                        m_display = style_display.block;
                    }
                }
                else if (m_float != element_float.none)
                {
                    // 3. Otherwise, if 'float' has a value other than 'none', the box is floated and 'display' is set
                    //    according to the table below.
                    if (m_display == style_display.inline_table)
                    {
                        m_display = style_display.table;
                    }
                    else if (m_display == style_display.inline ||
                               m_display == style_display.table_row_group ||
                               m_display == style_display.table_column ||
                               m_display == style_display.table_column_group ||
                               m_display == style_display.table_header_group ||
                               m_display == style_display.table_footer_group ||
                               m_display == style_display.table_row ||
                               m_display == style_display.table_cell ||
                               m_display == style_display.table_caption ||
                               m_display == style_display.inline_block)
                    {
                        m_display = style_display.block;
                    }
                }
                else if (!el.have_parent)
                {
                    // 4. Otherwise, if the element is the root element, 'display' is set according to the table below,
                    //    except that it is undefined in CSS 2.2 whether a specified value of 'list-item' becomes a
                    //    computed value of 'block' or 'list-item'.
                    if (m_display == style_display.inline_table)
                    {
                        m_display = style_display.table;
                    }
                    else if (m_display == style_display.inline ||
                        m_display == style_display.table_row_group ||
                        m_display == style_display.table_column ||
                        m_display == style_display.table_column_group ||
                        m_display == style_display.table_header_group ||
                        m_display == style_display.table_footer_group ||
                        m_display == style_display.table_row ||
                        m_display == style_display.table_cell ||
                        m_display == style_display.table_caption ||
                        m_display == style_display.inline_block ||
                        m_display == style_display.list_item)
                    {
                        m_display = style_display.block;
                    }
                }
            }
            // 5. Otherwise, the remaining 'display' property values apply as specified.

            if (m_el_position == element_position.absolute || m_el_position == element_position.@fixed || m_el_position == element_position.@relative)
            {
                m_css_offsets.left.fromString(el.get_style_property("left", false, "auto"), "auto");
                m_css_offsets.right.fromString(el.get_style_property("right", false, "auto"), "auto");
                m_css_offsets.top.fromString(el.get_style_property("top", false, "auto"), "auto");
                m_css_offsets.bottom.fromString(el.get_style_property("bottom", false, "auto"), "auto");
#if H3ML
                m_css_offsets.front.fromString(el.get_style_property("front", false, "auto"), "auto");
                m_css_offsets.back.fromString(el.get_style_property("back", false, "auto"), "auto");
#endif

                doc.cvt_units(m_css_offsets.left, m_font_size);
                doc.cvt_units(m_css_offsets.right, m_font_size);
                doc.cvt_units(m_css_offsets.top, m_font_size);
                doc.cvt_units(m_css_offsets.bottom, m_font_size);
#if H3ML
                doc.cvt_units(m_css_offsets.front, m_font_size);
                doc.cvt_units(m_css_offsets.back, m_font_size);
#endif
            }

            var va = el.get_style_property("vertical-align", true, "baseline");
            m_vertical_align = (vertical_align)value_index(va, vertical_align_strings, (int)vertical_align.baseline);

            m_clear = (element_clear)value_index(el.get_style_property("clear", false, "none"), element_clear_strings, (int)element_clear.none);

            m_css_text_indent.fromString(el.get_style_property("text-indent", true, "0"), "0");

            m_css_width.fromString(el.get_style_property("width", false, "auto"), "auto");
            m_css_height.fromString(el.get_style_property("height", false, "auto"), "auto");
#if H3ML
            m_css_depth.fromString(el.get_style_property("depth", false, "auto"), "auto");
#endif

            doc.cvt_units(m_css_width, m_font_size);
            doc.cvt_units(m_css_height, m_font_size);
#if H3ML
            doc.cvt_units(m_css_depth, m_font_size);
#endif

            m_css_min_width.fromString(el.get_style_property("min-width", false, "0"));
            m_css_min_height.fromString(el.get_style_property("min-height", false, "0"));
#if H3ML
            m_css_min_depth.fromString(el.get_style_property("min-depth", false, "0"));
#endif

            m_css_max_width.fromString(el.get_style_property("max-width", false, "none"), "none");
            m_css_max_height.fromString(el.get_style_property("max-height", false, "none"), "none");
#if H3ML
            m_css_max_depth.fromString(el.get_style_property("max-depth", false, "none"), "none");
#endif

            doc.cvt_units(m_css_min_width, m_font_size);
            doc.cvt_units(m_css_min_height, m_font_size);
#if H3ML
            doc.cvt_units(m_css_min_depth, m_font_size);
#endif

            m_css_margins.left.fromString(el.get_style_property("margin-left", false, "0"), "auto");
            m_css_margins.right.fromString(el.get_style_property("margin-right", false, "0"), "auto");
            m_css_margins.top.fromString(el.get_style_property("margin-top", false, "0"), "auto");
            m_css_margins.bottom.fromString(el.get_style_property("margin-bottom", false, "0"), "auto");
#if H3ML
            m_css_margins.front.fromString(el.get_style_property(_t("margin-front"), false, _t("0")), _t("auto"));
            m_css_margins.back.fromString(el.get_style_property(_t("margin-back"), false, _t("0")), _t("auto"));
#endif

            doc.cvt_units(m_css_margins.left, m_font_size);
            doc.cvt_units(m_css_margins.right, m_font_size);
            doc.cvt_units(m_css_margins.top, m_font_size);
            doc.cvt_units(m_css_margins.bottom, m_font_size);
#if H3ML
            doc.cvt_units(m_css_margins.front, m_font_size);
            doc.cvt_units(m_css_margins.back, m_font_size);
#endif

            m_css_padding.left.fromString(el.get_style_property("padding-left", false, "0"), "");
            m_css_padding.right.fromString(el.get_style_property("padding-right", false, "0"), "");
            m_css_padding.top.fromString(el.get_style_property("padding-top", false, "0"), "");
            m_css_padding.bottom.fromString(el.get_style_property("padding-bottom", false, "0"), "");
#if H3ML
            m_css_padding.front.fromString(el.get_style_property(_t("padding-front"), false, _t("0")), _t(""));
            m_css_padding.back.fromString(el.get_style_property(_t("padding-back"), false, _t("0")), _t(""));
#endif

            doc.cvt_units(m_css_padding.left, m_font_size);
            doc.cvt_units(m_css_padding.right, m_font_size);
            doc.cvt_units(m_css_padding.top, m_font_size);
            doc.cvt_units(m_css_padding.bottom, m_font_size);
#if H3ML
            doc.cvt_units(m_css_padding.front, m_font_size);
            doc.cvt_units(m_css_padding.back, m_font_size);
#endif

            m_css_borders.left.width.fromString(el.get_style_property("border-left-width", false, "medium"), border_width_strings);
            m_css_borders.right.width.fromString(el.get_style_property("border-right-width", false, "medium"), border_width_strings);
            m_css_borders.top.width.fromString(el.get_style_property("border-top-width", false, "medium"), border_width_strings);
            m_css_borders.bottom.width.fromString(el.get_style_property("border-bottom-width", false, "medium"), border_width_strings);
#if H3ML
            m_css_borders.front.width.fromString(el.get_style_property(_t("border-front-width"), false, _t("medium")), border_width_strings);
            m_css_borders.back.width.fromString(el.get_style_property(_t("border-back-width"), false, _t("medium")), border_width_strings);
#endif

            doc.cvt_units(m_css_borders.left.width, m_font_size);
            doc.cvt_units(m_css_borders.right.width, m_font_size);
            doc.cvt_units(m_css_borders.top.width, m_font_size);
            doc.cvt_units(m_css_borders.bottom.width, m_font_size);
#if H3ML
            doc.cvt_units(m_css_borders.front.width, m_font_size);
            doc.cvt_units(m_css_borders.back.width, m_font_size);
#endif

            m_css_borders.left.color = web_color.from_string(el.get_style_property("border-left-color", false, ""), doc.container);
            m_css_borders.left.style = (border_style)value_index(el.get_style_property("border-left-style", false, "none"), border_style_strings, (int)border_style.none);

            m_css_borders.right.color = web_color.from_string(el.get_style_property("border-right-color", false, ""), doc.container);
            m_css_borders.right.style = (border_style)value_index(el.get_style_property("border-right-style", false, "none"), border_style_strings, (int)border_style.none);

            m_css_borders.top.color = web_color.from_string(el.get_style_property("border-top-color", false, ""), doc.container);
            m_css_borders.top.style = (border_style)value_index(el.get_style_property("border-top-style", false, "none"), border_style_strings, (int)border_style.none);

            m_css_borders.bottom.color = web_color.from_string(el.get_style_property("border-bottom-color", false, ""), doc.container);
            m_css_borders.bottom.style = (border_style)value_index(el.get_style_property("border-bottom-style", false, "none"), border_style_strings, (int)border_style.none);

#if H3ML
            m_css_borders.front.color = web_color.from_string(el.get_style_property("border-front-color", false, ""), doc.container);
            m_css_borders.front.style = (border_style)value_index(el.get_style_property("border-front-style", false, "none"), border_style_strings, (int)border_style.none);

            m_css_borders.back.color = web_color.from_string(el.get_style_property("border-back-color", false, ""), doc.container);
            m_css_borders.back.style = (border_style)value_index(el.get_style_property("border-back-style", false, "none"), border_style_strings, (int)border_style.none);
#endif

            m_css_borders.radius.top_left_x.fromString(el.get_style_property("border-top-left-radius-x", false, "0"));
            m_css_borders.radius.top_left_y.fromString(el.get_style_property("border-top-left-radius-y", false, "0"));
#if H3ML
            m_css_borders.radius.top_left_z.fromString(el.get_style_property("border-top-left-radius-z", false, "0"));
#endif

            m_css_borders.radius.top_right_x.fromString(el.get_style_property("border-top-right-radius-x", false, "0"));
            m_css_borders.radius.top_right_y.fromString(el.get_style_property("border-top-right-radius-y", false, "0"));
#if H3ML
            m_css_borders.radius.top_right_z.fromString(el.get_style_property("border-top-right-radius-z", false, "0"));
#endif

            m_css_borders.radius.bottom_right_x.fromString(el.get_style_property("border-bottom-right-radius-x", false, "0"));
            m_css_borders.radius.bottom_right_y.fromString(el.get_style_property("border-bottom-right-radius-y", false, "0"));
#if H3ML
            m_css_borders.radius.bottom_right_z.fromString(el.get_style_property("border-bottom-right-radius-z", false, "0"));
#endif

            m_css_borders.radius.bottom_left_x.fromString(el.get_style_property("border-bottom-left-radius-x", false, "0"));
            m_css_borders.radius.bottom_left_y.fromString(el.get_style_property("border-bottom-left-radius-y", false, "0"));
#if H3ML
            m_css_borders.radius.bottom_left_z.fromString(el.get_style_property("border-bottom-left-radius-z", false, "0"));
#endif

            doc.cvt_units(m_css_borders.radius.bottom_left_x, m_font_size);
            doc.cvt_units(m_css_borders.radius.bottom_left_y, m_font_size);
            doc.cvt_units(m_css_borders.radius.bottom_right_x, m_font_size);
            doc.cvt_units(m_css_borders.radius.bottom_right_y, m_font_size);
            doc.cvt_units(m_css_borders.radius.top_left_x, m_font_size);
            doc.cvt_units(m_css_borders.radius.top_left_y, m_font_size);
            doc.cvt_units(m_css_borders.radius.top_right_x, m_font_size);
            doc.cvt_units(m_css_borders.radius.top_right_y, m_font_size);
#if H3ML
            doc.cvt_units(m_css_borders.radius.bottom_left_z, m_font_size);
            doc.cvt_units(m_css_borders.radius.bottom_right_z, m_font_size);
            doc.cvt_units(m_css_borders.radius.top_left_z, m_font_size);
            doc.cvt_units(m_css_borders.radius.top_right_z, m_font_size);
#endif

            doc.cvt_units(m_css_text_indent, m_font_size);

            css_length line_height = default;
            line_height.fromString(el.get_style_property("line-height", true, "normal"), "normal");
            if (line_height.is_predefined)
            {
                m_line_height = m_font_metrics.height;
                m_lh_predefined = true;
            }
            else if (line_height.units == css_units.none)
            {
                m_line_height = (int)(line_height.val * (float)m_font_size);
                m_lh_predefined = false;
            }
            else
            {
                m_line_height = doc.to_pixels(line_height, m_font_size, m_font_size);
                m_lh_predefined = false;
            }

            if (m_display == style_display.list_item)
            {
                var list_type = el.get_style_property("list-style-type", true, "disc");
                m_list_style_type = (list_style_type)value_index(list_type, list_style_type_strings, (int)list_style_type.disc);

                var list_pos = el.get_style_property("list-style-position", true, "outside");
                m_list_style_position = (list_style_position)value_index(list_pos, list_style_position_strings, (int)list_style_position.outside);

                var list_image = el.get_style_property("list-style-image", true, null);
                if (!string.IsNullOrEmpty(list_image))
                {
                    css.parse_css_url(list_image, out var url);

                    var list_image_baseurl = el.get_style_property("list-style-image-baseurl", true, null);
                    doc.container.load_image(url, list_image_baseurl, null, true);
                }
            }

            m_text_transform = (text_transform)value_index(el.get_style_property("text-transform", true, "none"), text_transform_strings, (int)text_transform.none);

            m_border_collapse = (border_collapse)value_index(el.get_style_property("border-collapse", true, "separate"), border_collapse_strings, (int)border_collapse.separate);

            if (m_border_collapse == border_collapse.separate)
            {
                m_css_border_spacing_x.fromString(el.get_style_property("-litehtml-border-spacing-x", true, "0px"));
                m_css_border_spacing_y.fromString(el.get_style_property("-litehtml-border-spacing-y", true, "0px"));
#if H3ML
                m_css_border_spacing_z.fromString(el.get_style_property("-litehtml-border-spacing-z", true, "0px"));
#endif

                doc.cvt_units(m_css_border_spacing_x, m_font_size);
                doc.cvt_units(m_css_border_spacing_y, m_font_size);
#if H3ML
                doc.cvt_units(m_css_border_spacing_z, m_font_size);
#endif
            }

            parse_background(el, doc);
        }

        void parse_font(element el, document doc)
        {
            // initialize font size
            var str = el.get_style_property("font-size", false, null);

            int parent_sz = 0;
            int doc_font_size = doc.container.get_default_font_size();
            var el_parent = el.parent();
            if (el_parent != null)
            {
                parent_sz = el_parent.css().get_font_size();
            }
            else
            {
                parent_sz = doc_font_size;
            }


            if (str == null)
            {
                m_font_size = parent_sz;
            }
            else
            {
                m_font_size = parent_sz;

                css_length sz = default;
                sz.fromString(str, font_size_strings, -1);
                if (sz.is_predefined)
                {
                    int idx_in_table = doc_font_size - 9;
                    if (idx_in_table >= 0 && idx_in_table <= 7)
                    {
                        if (sz.predef >= (int)font_size.xx_small && sz.predef <= (int)font_size.xx_large)
                        {
                            m_font_size = font_size_table[idx_in_table][sz.predef];
                        }
                        else
                        {
                            m_font_size = parent_sz;
                        }
                    }
                    else
                    {
                        switch ((font_size)sz.predef)
                        {
                            case font_size.xx_small:
                                m_font_size = doc_font_size * 3 / 5;
                                break;
                            case font_size.x_small:
                                m_font_size = doc_font_size * 3 / 4;
                                break;
                            case font_size.small:
                                m_font_size = doc_font_size * 8 / 9;
                                break;
                            case font_size.large:
                                m_font_size = doc_font_size * 6 / 5;
                                break;
                            case font_size.x_large:
                                m_font_size = doc_font_size * 3 / 2;
                                break;
                            case font_size.xx_large:
                                m_font_size = doc_font_size * 2;
                                break;
                            default:
                                m_font_size = parent_sz;
                                break;
                        }
                    }
                }
                else
                {
                    if (sz.units == css_units.percentage)
                    {
                        m_font_size = sz.calc_percent(parent_sz);
                    }
                    else if (sz.units == css_units.none)
                    {
                        m_font_size = parent_sz;
                    }
                    else
                    {
                        m_font_size = doc.to_pixels(sz, parent_sz);
                    }
                }
            }

            // initialize font
            var name = el.get_style_property("font-family", true, "inherit");
            var weight = el.get_style_property("font-weight", true, "normal");
            var style = el.get_style_property("font-style", true, "normal");
            var decoration = el.get_style_property("text-decoration", true, "none");

            m_font = doc.get_font(name, m_font_size, weight, style, decoration, out m_font_metrics);
        }

        void parse_background(element el, document doc)
        {
            // parse background-color
            m_bg.m_color = el.get_color("background-color", false, new(0, 0, 0, 0));

            // parse background-position
            var str = el.get_style_property("background-position", false, "0% 0%");
            if (str != null)
            {
                List<string> res = new();
                split_string(str, res, " \t");
                if (!res.empty())
                {
                    if (res.Count == 1)
                    {
                        if (value_in_list(res[0], "left;right;center"))
                        {
                            m_bg.m_position.x.fromString(res[0], "left;right;center");
                            m_bg.m_position.y.set_value(50, css_units.percentage);
#if H3ML
                            m_bg.m_position.z.set_value(50, css_units.percentage);
#endif
                        }
                        else if (value_in_list(res[0], "top;bottom;center"))
                        {
                            m_bg.m_position.y.fromString(res[0], "top;bottom;center");
                            m_bg.m_position.x.set_value(50, css_units.percentage);
#if H3ML
                            m_bg.m_position.z.set_value(50, css_units.percentage);
#endif
                        }
                        else
                        {
                            m_bg.m_position.x.fromString(res[0], "left;right;center");
                            m_bg.m_position.y.set_value(50, css_units.percentage);
#if H3ML
                            m_bg.m_position.z.set_value(50, css_units.percentage);
#endif
                        }
                    }
                    else
                    {
                        if (value_in_list(res[0], "left;right"))
                        {
                            m_bg.m_position.x.fromString(res[0], "left;right;center");
                            m_bg.m_position.y.fromString(res[1], "top;bottom;center");
#if H3ML
                            m_bg.m_position.z.set_value(50, css_units.percentage);
#endif
                        }
                        else if (value_in_list(res[0], "top;bottom"))
                        {
                            m_bg.m_position.x.fromString(res[1], "left;right;center");
                            m_bg.m_position.y.fromString(res[0], "top;bottom;center");
#if H3ML
                            m_bg.m_position.z.set_value(50, css_units.percentage);
#endif
                        }
                        else if (value_in_list(res[1], "left;right"))
                        {
                            m_bg.m_position.x.fromString(res[1], "left;right;center");
                            m_bg.m_position.y.fromString(res[0], "top;bottom;center");
#if H3ML
                            m_bg.m_position.z.set_value(50, css_units.percentage);
#endif
                        }
                        else if (value_in_list(res[1], "top;bottom"))
                        {
                            m_bg.m_position.x.fromString(res[0], "left;right;center");
                            m_bg.m_position.y.fromString(res[1], "top;bottom;center");
#if H3ML
                            m_bg.m_position.z.set_value(50, css_units.percentage);
#endif
                        }
                        else
                        {
                            m_bg.m_position.x.fromString(res[0], "left;right;center");
                            m_bg.m_position.y.fromString(res[1], "top;bottom;center");
#if H3ML
                            m_bg.m_position.z.set_value(50, css_units.percentage);
#endif
                        }
                    }

                    if (m_bg.m_position.x.is_predefined)
                    {
                        switch (m_bg.m_position.x.predef)
                        {
                            case 0:
                                m_bg.m_position.x.set_value(0, css_units.percentage);
                                break;
                            case 1:
                                m_bg.m_position.x.set_value(100, css_units.percentage);
                                break;
                            case 2:
                                m_bg.m_position.x.set_value(50, css_units.percentage);
                                break;
                        }
                    }
                    if (m_bg.m_position.y.is_predefined)
                    {
                        switch (m_bg.m_position.y.predef)
                        {
                            case 0:
                                m_bg.m_position.y.set_value(0, css_units.percentage);
                                break;
                            case 1:
                                m_bg.m_position.y.set_value(100, css_units.percentage);
                                break;
                            case 2:
                                m_bg.m_position.y.set_value(50, css_units.percentage);
                                break;
                        }
                    }
#if H3ML
                    if (m_bg.m_position.z.is_predefined)
                    {
                        switch (m_bg.m_position.z.predef)
                        {
                            case 0:
                                m_bg.m_position.z.set_value(0, css_units.percentage);
                                break;
                            case 1:
                                m_bg.m_position.z.set_value(100, css_units.percentage);
                                break;
                            case 2:
                                m_bg.m_position.z.set_value(50, css_units.percentage);
                                break;
                        }
                    }
#endif
                }
                else
                {
                    m_bg.m_position.x.set_value(0, css_units.percentage);
                    m_bg.m_position.y.set_value(0, css_units.percentage);
#if H3ML
                    m_bg.m_position.z.set_value(0, css_units.percentage);
#endif
                }
            }
            else
            {
                m_bg.m_position.y.set_value(0, css_units.percentage);
                m_bg.m_position.x.set_value(0, css_units.percentage);
#if H3ML
                m_bg.m_position.z.set_value(0, css_units.percentage);
#endif
            }

            str = el.get_style_property("background-size", false, "auto");
            if (str != null)
            {
                List<string> res = new();
                split_string(str, res, " \t");
                if (!res.empty())
                {
                    m_bg.m_position.width.fromString(res[0], background_size_strings);
                    if (res.Count > 1)
                    {
                        m_bg.m_position.height.fromString(res[1], background_size_strings);
                    }
                    else
                    {
                        m_bg.m_position.height.predef = (int)background_size.auto;
                    }
#if H3ML
                    if (res.Count > 2)
                    {
                        m_bg.m_position.depth.fromString(res[2], background_size_strings);
                    }
                    else
                    {
                        m_bg.m_position.depth.predef = (int)background_size.auto;
                    }
#endif
                }
                else
                {
                    m_bg.m_position.width.predef = (int)background_size.auto;
                    m_bg.m_position.height.predef = (int)background_size.auto;
#if H3ML
                    m_bg.m_position.depth.predef = (int)background_size.auto;
#endif
                }
            }

            doc.cvt_units(m_bg.m_position.x, m_font_size);
            doc.cvt_units(m_bg.m_position.y, m_font_size);
#if H3ML
            doc.cvt_units(m_bg.m_position.z, m_font_size);
#endif
            doc.cvt_units(m_bg.m_position.width, m_font_size);
            doc.cvt_units(m_bg.m_position.height, m_font_size);
#if H3ML
            doc.cvt_units(m_bg.m_position.depth, m_font_size);
#endif

            // parse background_attachment
            m_bg.m_attachment = (background_attachment)value_index(
                    el.get_style_property("background-attachment", false, "scroll"),
                    background_attachment_strings,
                    (int)background_attachment.scroll);

            // parse background_attachment
            m_bg.m_repeat = (background_repeat)value_index(
                    el.get_style_property("background-repeat", false, "repeat"),
                    background_repeat_strings,
                    (int)background_repeat.repeat);

            // parse background_clip
            m_bg.m_clip = (background_box)value_index(
                    el.get_style_property("background-clip", false, "border-box"),
                    background_box_strings,
                    (int)background_box.border);

            // parse background_origin
            m_bg.m_origin = (background_box)value_index(
                    el.get_style_property("background-origin", false, "padding-box"),
                    background_box_strings,
                    (int)background_box.content);

            // parse background-image
            css.parse_css_url(el.get_style_property("background-image", false, ""), out m_bg.m_image);
            m_bg.m_baseurl = el.get_style_property("background-image-baseurl", false, "");

            if (!m_bg.m_image.empty())
            {
                doc.container.load_image(m_bg.m_image, m_bg.m_baseurl.empty() ? null : m_bg.m_baseurl, null, true);
            }
        }

        public IList<(string, string)> dump_get_attrs()
        {
            List<(string, string)> ret = new();

            ret.Add(("display", index_value((int)m_display, style_display_strings)));
            ret.Add(("el_position", index_value((int)m_el_position, element_position_strings)));
            ret.Add(("text_align", index_value((int)m_text_align, text_align_strings)));
            ret.Add(("font_size", m_font_size.ToString());
            ret.Add(("overflow", index_value((int)m_overflow, overflow_strings)));
            ret.Add(("white_space", index_value((int)m_white_space, white_space_strings)));
            ret.Add(("visibility", index_value((int)m_visibility, visibility_strings)));
            ret.Add(("box_sizing", index_value((int)m_box_sizing, box_sizing_strings)));
            ret.Add(("z_index", m_z_index.ToString()));
            ret.Add(("vertical_align", index_value((int)m_vertical_align, vertical_align_strings)));
            ret.Add(("float", index_value((int)m_float, element_float_strings)));
            ret.Add(("clear", index_value((int)m_clear, element_clear_strings)));
            ret.Add(("margins", m_css_margins.ToString()));
            ret.Add(("padding", m_css_padding.ToString()));
            ret.Add(("borders", m_css_borders.ToString()));
            ret.Add(("width", m_css_width.ToString()));
            ret.Add(("height", m_css_height.ToString()));
#if H3ML
            ret.Add(("depth", m_css_depth.ToString()));
#endif
            ret.Add(("min_width", m_css_min_width.ToString()));
            ret.Add(("min_height", m_css_min_width.ToString()));
            ret.Add(("max_width", m_css_max_width.ToString()));
            ret.Add(("max_height", m_css_max_width.ToString()));
            ret.Add(("offsets", m_css_offsets.ToString()));
            ret.Add(("text_indent", m_css_text_indent.ToString()));
            ret.Add(("line_height", m_line_height.ToString()));
            ret.Add(("list_style_type", index_value((int)m_list_style_type, list_style_type_strings)));
            ret.Add(("list_style_position", index_value((int)m_list_style_position, list_style_position_strings)));
            ret.Add(("border_spacing_x", m_css_border_spacing_x.ToString()));
            ret.Add(("border_spacing_y", m_css_border_spacing_y.ToString()));
#if H3ML
            ret.Add(("border_spacing_z", m_css_border_spacing_z.ToString()));
#endif

            return ret;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public element_position get_position() => m_el_position;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_position(element_position mElPosition) => m_el_position = mElPosition;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public text_align get_text_align() => m_text_align;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_text_align(text_align mTextAlign) => m_text_align = mTextAlign;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public overflow get_overflow() => m_overflow;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_overflow(overflow mOverflow) => m_overflow = mOverflow;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public white_space get_white_space() => m_white_space;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_white_space(white_space mWhiteSpace) => m_white_space = mWhiteSpace;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public style_display get_display() => m_display;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_display(style_display mDisplay) => m_display = mDisplay;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public visibility get_visibility() => m_visibility;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_visibility(visibility mVisibility) => m_visibility = mVisibility;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public box_sizing get_box_sizing() => m_box_sizing;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_box_sizing(box_sizing mBoxSizing) => m_box_sizing = mBoxSizing;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public int get_z_index() => m_z_index;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_z_index(int mZIndex) => m_z_index = mZIndex;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public vertical_align get_vertical_align() => m_vertical_align;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_vertical_align(vertical_align mVerticalAlign) => m_vertical_align = mVerticalAlign;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public element_float get_float() => m_float;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_float(element_float mFloat) => m_float = mFloat;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public element_clear get_clear() => m_clear;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_clear(element_clear mClear) => m_clear = mClear;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_margins get_margins() => ref m_css_margins;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_margins(ref css_margins mCssMargins) => m_css_margins = mCssMargins;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_margins get_padding() => ref m_css_padding;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_padding(ref css_margins mCssPadding) => m_css_padding = mCssPadding;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_borders get_borders() => ref m_css_borders;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_borders(ref css_borders mCssBorders) => m_css_borders = mCssBorders;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_width() => ref m_css_width;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_width(ref css_length mCssWidth) => m_css_width = mCssWidth;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_height() => ref m_css_height;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_height(ref css_length mCssHeight) => m_css_height = mCssHeight;

#if H3ML
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_depth() => ref m_css_depth;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_depth(ref css_length mCssDepth) => m_css_depth = mCssDepth;
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_min_width() => ref m_css_min_width;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_min_width(ref css_length mCssMinWidth) => m_css_min_width = mCssMinWidth;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_min_height() => ref m_css_min_height;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_min_height(ref css_length mCssMinHeight) => m_css_min_height = mCssMinHeight;

#if H3ML
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_min_depth() => ref m_css_min_depth;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_min_depth(ref css_length mCssMinDepth) => m_css_min_depth = mCssMinDepth;
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_max_width() => ref m_css_max_width;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_max_width(ref css_length mCssMaxWidth) => m_css_max_width = mCssMaxWidth;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_max_height() => ref m_css_max_height;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_max_height(ref css_length mCssMaxHeight) => m_css_max_height = mCssMaxHeight;

#if H3ML
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_max_depth() => ref m_css_max_depth;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_max_depth(ref css_length mCssMaxDepth) => m_css_max_depth = mCssMaxDepth;
#endif

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_offsets get_offsets() => ref m_css_offsets;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_offsets(ref css_offsets mCssOffsets) => m_css_offsets = mCssOffsets;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_text_indent() => ref m_css_text_indent;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_text_indent(ref css_length mCssTextIndent) => m_css_text_indent = mCssTextIndent;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public int get_line_height() => m_line_height;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_line_height(int mLineHeight) => m_line_height = mLineHeight;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public bool is_line_height_predefined() => m_lh_predefined;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_line_height_predefined(bool mLhPredefined) => m_lh_predefined = mLhPredefined;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public list_style_type get_list_style_type() => m_list_style_type;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_list_style_type(list_style_type mListStyleType) => m_list_style_type = mListStyleType;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public list_style_position get_list_style_position() => m_list_style_position;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_list_style_position(list_style_position mListStylePosition) => m_list_style_position = mListStylePosition;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref background get_bg() => ref m_bg;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_bg(ref background mBg) => m_bg = mBg;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public int get_font_size() => m_font_size;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_font_size(int mFontSize) => m_font_size = mFontSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public IntPtr get_font() => m_font;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_font(IntPtr mFont) => m_font = mFont;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref font_metrics get_font_metrics() => ref m_font_metrics;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_font_metrics(ref font_metrics mFontMetrics) => m_font_metrics = mFontMetrics;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public text_transform get_text_transform() => m_text_transform;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_text_transform(text_transform mTextTransform) => m_text_transform = mTextTransform;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public border_collapse get_border_collapse() => m_border_collapse;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_border_collapse(border_collapse mBorderCollapse) => m_border_collapse = mBorderCollapse;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_border_spacing_x() => ref m_css_border_spacing_x;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void set_border_spacing_x(ref css_length mBorderSpacingX) => m_css_border_spacing_x = mBorderSpacingX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_border_spacing_y() => ref m_css_border_spacing_y;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void get_border_spacing_y(ref css_length mBorderSpacingY) => m_css_border_spacing_y = mBorderSpacingY;

#if H3ML
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public ref css_length get_border_spacing_z() => ref m_css_border_spacing_z;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] public void get_border_spacing_z(ref css_length mBorderSpacingZ) => m_css_border_spacing_z = mBorderSpacingZ;
#endif
    }
}