using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson12
{
    struct Rectangle
    {
        private int m_width;

        public int Width
        {
            get
            {
                return m_width;
            }
            set
            {
                m_width = value;
            }
        }

        private int m_height;

        public int Height
        {
            get
            {
                return m_height;
            }
            set
            {
                m_height = value;
            }
        }
    }
}
