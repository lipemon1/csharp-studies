using System;
using UnityEngine;

namespace ImplementAningInterface
{
    public class Rectangle : IComparable
    {
        #region Fields

        private int width;
        private int height;

        #endregion

        #region Constructor

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        #endregion

        #region Properties

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("[Rectangle: Width={0}, Height={1}]", width, height);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            
            var otherRectangle = obj as Rectangle;
            if (otherRectangle != null)
            {
                if (width * height < otherRectangle.width * otherRectangle.height)
                    return -1;
                else if (width * height == otherRectangle.width * otherRectangle.height)
                    return 0;
                else
                    return 1;
            }
            else
            {
                throw new ArgumentException("Object is not a Rectangle");
            }
        }

        #endregion
    }
}
