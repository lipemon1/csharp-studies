using System;
using DynamicArrays;
using UnityEngine;

namespace ImplementAningInterface
{
    public class Program : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var rectangles = new OrderedDynamicArray<Rectangle>();
            
            rectangles.Add(new Rectangle(3,4));
            rectangles.Add(new Rectangle(2, 2));
            rectangles.Add(new Rectangle(1, 2));

            Console.Write(rectangles.ToString());
        }
    }
}
