using System.Text;
using UnityEngine;

namespace DynamicArrays
{
    public abstract class IntDynamicArray
    {
        private const int ExpandMultiplyFactor = 2;
        protected int[] items;
        protected int count;

        #region Constructor

        protected IntDynamicArray()
        {
            items = new int[4];
            count = 0;
        }

        #endregion

        #region Properties

        public int Count
        {
            get { return count; }
        }

        #endregion

        #region Public Methods

        public abstract void Add(int item);
        public abstract bool Remove(int item);
        public abstract int IndexOf(int item);

        public void Clear()
        {
            count = 0;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            for (var i = 0; i < count; i++)
            {
                builder.Append(items[i]);
                if (i < count - 1)
                {
                    builder.Append(",");
                }
            }

            return builder.ToString();
        }            

        #endregion

        #region Protected Methods

        protected void Expand()
        {
            var newItems = new int[items.Length * ExpandMultiplyFactor];

            for (var i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }

            items = newItems;
        }

        #endregion
    }
}
