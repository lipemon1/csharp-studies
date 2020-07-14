using System.Collections.Generic;

namespace DynamicArrays
{
    public class UnorderedIntDynamicArray : IntDynamicArray
    {
        #region Construtor

        public UnorderedIntDynamicArray() : base()
        {
            
        }

        #endregion

        #region Public Methods

        public override void Add(int item)
        {
            if(count == items.Length)
                Expand();

            items[count] = item;
            count++;
        }
        
        public override bool Remove(int item)
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

        public override int IndexOf(int item)
        {
            for (var i = 0; i < count; i++)
            {
                if (items[i] == item)
                    return i;
            }

            return -1;
        }

        public int LastIndexOf(int item)
        {
            for (int i = count - 1; i >= 0; i--)
            {
                if (items[i] == item)
                    return i;
            }

            return -1;
        }

        public List<int> AllIndexesOf(int item)
        {
            var foundedIndexes = new List<int>();

            for (var i = 0; i < count; i++)
            {
                if(items[i] == item)
                    foundedIndexes.Add(i);
            }

            return foundedIndexes;
        }

        #endregion
    }
}
