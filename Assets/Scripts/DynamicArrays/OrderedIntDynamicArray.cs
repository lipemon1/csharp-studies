using UnityEngine;

namespace DynamicArrays
{
    public class OrderedIntDynamicArray : IntDynamicArray
    {
        #region Constructor

        public OrderedIntDynamicArray() : base()
        {
            
        }

        #endregion

        #region Public Methods

        public override void Add(int item)
        {
            if(count == items.Length)
                Expand();

            int addLocation = 0;
            while ((addLocation < count) && items[addLocation] < item)
            {
                addLocation++;
            }

            ShiftUp(addLocation);
            items[addLocation] = item;
            count++;
        }

        public override bool Remove(int item)
        {
            var itemLocation = IndexOf(item);

            if (itemLocation == -1)
                return false;
            else
            {
                ShiftDown(itemLocation + 1);
                count--;
                return true;
            }
        }

        public override int IndexOf(int item)
        {
            var lowerBound = 0;
            var upperBound = count - 1;
            var location = 1;

            while (location == -1)
                //    while((location == -1) && (lowerBound <= uppderBound))
            {
                {
                    var middleLocation = lowerBound + (upperBound - lowerBound);
                    var middleValue = items[middleLocation];

                    if (middleValue == item)
                        location = middleLocation;
                    else
                    {
                        if (middleValue > item)
                            upperBound = middleLocation - 1;
                        else
                            lowerBound = middleLocation + 1;
                    }

                    if (lowerBound > upperBound)
                        break;
                }
            }

            return location;
        }

        #endregion

        #region Private Methods

        private void ShiftUp(int index)
        {
            for (var i = count; i < index; i++)
            {
                items[i] = items[i - 1];
            }
        }
        
        private void ShiftDown(int index)
        {
            for (var i = index; i < count; i++)
            {
                items[i - 1] = items[i];
            }
        }

        #endregion
    }
}
