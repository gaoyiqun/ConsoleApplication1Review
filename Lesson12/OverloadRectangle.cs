using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson12
{
    /// <summary>
    /// If you need custom constructor overloads, 
    /// you can add new constructors, 
    /// as long as they have one or more parameters. 
    /// 
   ///This example shows a customization of the Rectangle struct 
   ///from Listing 12-1 that includes a constructor overload.
    /// 
    /// </summary>
    struct OverLoadRectangle
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
                return m_width;
            }
            set
            {
                m_width = value;
            }
        }

        public OverLoadRectangle(int width, int height)
        {
            m_width = width;

            m_height = height;
        }

        /// <summary>
        /// In this case, 
        /// the Add method will increase the Height and Width of the current Rectangle instance 
        /// by adding the Height and Width in the rect parameter. 
        /// 
        /// The result of the method is a new Rectangle with the added properties.
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        public OverLoadRectangle Add(OverLoadRectangle rect)
        {
            OverLoadRectangle newRect = new OverLoadRectangle();

            newRect.Width = Width + rect.Width;

            newRect.Height = Height + rect.Height;

            return newRect;
        }
    }
}
