using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Right
        {
            get
            {
                return Left + Width;
            }
        }

        public double Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public bool Inside(Rectangle other)
        {
            return Left >= other.Left && Right <= other.Right
                && Top >= other.Top && Bottom <= other.Bottom;
        }
    }
}
