using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Sort
    {
        public delegate dynamic ActionDelegate(dynamic a, dynamic b);
        public static void SortAsc(List<int> integers)
        {
            bool sorted = false;
            do
            {
                sorted = true;
                for (int i = 0; i < integers.Count - 1; i++)
                {
                    if (integers[i] > integers[i + 1])
                    {
                        Int32 tmp = integers[i];
                        integers[i] = integers[i + 1];
                        integers[i + 1] = tmp;
                        sorted = false;
                    }
                }
            } while (!sorted);
        }

        public static void UniversalSort(ArrayList items, 
            ActionDelegate rule, ActionDelegate rule2)
        {
            bool sorted = false;
            do
            {
                sorted = true;
                for (int i = 0; i < items.Count - 1; i++)
                {
                    if (rule(items[i], items[i + 1]) > 0)
                    {
                        dynamic tmp = items[i];
                        items[i] = items[i + 1];
                        items[i + 1] = tmp;
                        sorted = false;
                    }
                    if(rule(items[i], items[i + 1]) == 0)
                    {
                        if (rule2(items[i], items[i + 1]) > 0)
                        {
                            dynamic tmp1 = items[i];
                            items[i] = items[i + 1];
                            items[i + 1] = tmp1;
                            sorted = false;
                        }
                    }
                }
            } while (!sorted);
        }
    }
}
