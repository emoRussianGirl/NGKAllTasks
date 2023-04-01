using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoInheritanceClass
{
    public class Child : Parent
    {
        public override void BubbleSort()
        {
            Array.Sort(base.Nums);

            MaxEl = Nums[Nums.Length - 1];
            MaxElIndex = Nums.Length - 1;
        }

        new public string Max()
        {
            return $"Max element: [{base.MaxElIndex}] = {base.MaxEl}";
        }

        public void Zamena()
        {
            int minElement = base.Nums.Min();

            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] == minElement)
                {
                     Nums[i] = base.MaxEl;
                    Nums[MaxElIndex] = minElement;
                }
            }
        }
    }
}
