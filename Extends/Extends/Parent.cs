using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoInheritanceClass
{
    public class Parent
    {
        public int[] Nums { get; private set; }

        public int ShowMaxEl
        {
            get
            {
                return MaxEl;
            }
        }

        protected int MaxEl;

        protected int MaxElIndex;

        public Parent()
        {
            Random rnb = new Random();
            Nums = new int[50];

            for (int i = 0; i < 50; i++)
            {
                Nums[i] = rnb.Next(-100, 100);
            }

            MaxEl = this.Max();
        }

        public virtual void BubbleSort()
        {
            for (int i = 0; i < Nums.Length; i++)
            {
                for (int j = 0; j < Nums.Length - 1 - i; j++)
                {
                    if (Nums[j] > Nums[j + 1])
                    {
                        int temp = Nums[j];
                        Nums[j] = Nums[j + 1];
                        Nums[j + 1] = temp;
                    }
                }
            }
        }

        public virtual int Max()
        {
            int maxElementIndex = 0;
            int maxElement = int.MinValue;

            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] > maxElement)
                {
                    maxElementIndex = i;
                    maxElement = Nums[i];
                }
            }

            MaxEl = maxElement;
            MaxElIndex = maxElementIndex;

            return maxElement;
        }
    }
}
