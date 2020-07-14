using System.Collections.Generic;

namespace DynamicArrays
{
    public class UnorderedIntDynamicArray<T> : DynamicArray<T>
    {
        #region Construtor

        public UnorderedIntDynamicArray() : base()
        {
            
        }

        #endregion

        #region Public Methods

        public override void Add(T item)
        {
            if(count == items.Length)
                Expand();

            items[count] = item;
            count++;
        }
        
        public override bool Remove(T item)
        {
            var itemLocation = IndexOf(item);
            
            if (itemLocation == -1)
            {
                return false;
            }
            else
            {
                items[itemLocation] = items[count - 1];
                count--;
                return true;
            }
        }

        public override int IndexOf(T item)
        {
            for (var i = 0; i < count; i++)
            {
                if (items[i].Equals(item))
                    return i;
            }

            return -1;
        }

        public int LastIndexOf(int item)
        {
            for (var i = count - 1; i >= 0; i--)
            {
                if (items[i].Equals(item))
                    return i;
            }

            return -1;
        }

        public List<int> AllIndexesOf(int item)
        {
            var foundedIndexes = new List<int>();

            for (var i = 0; i < count; i++)
            {
                if(items[i].Equals(item))
                    foundedIndexes.Add(i);
            }

            return foundedIndexes;
        }

        #endregion
    }
}
