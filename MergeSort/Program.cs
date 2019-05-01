using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(42);
            list.Add(7);
            list.Add(51);
            list.Add(17);
            list.Add(99);
            list.Add(64);
            list.Add(52);
            list.Add(96);
            list.Add(420);
            list.Add(69);

            list = MergeSort(list);
        }

        static List<int> MergeSort(List<int> list)
        {
            if (list.Count()==1)
            {
                return list;
            }
            else
            {
                //decompose
                int cuttingpoint = list.Count / 2;
                List<int> left = new List<int>();
                List<int> right = new List<int>();
                for (int i = 0; i<list.Count(); i++)
                {
                    if (i<cuttingpoint)
                    {
                        left.Add(list[i]);
                    }
                    else
                    {
                        right.Add(list[i]);
                    }
                }

                //recursive call
                left = MergeSort(left);
                right = MergeSort(right);

                //recombine smaller solutions
                int leftIndex = 0;
                int rightIndex = 0;
                List<int> sortedList = new List<int>();

                while (leftIndex < left.Count() || rightIndex < right.Count())
                {
                    if (leftIndex >= left.Count())
                    {
                        sortedList.Add(right[rightIndex]);
                        rightIndex++;
                        continue;
                    }
                    if (rightIndex >= right.Count())
                    {
                        sortedList.Add(left[leftIndex]);
                        leftIndex++;
                        continue;
                    }
                    if (left[leftIndex] < right[rightIndex])
                    {
                        sortedList.Add(left[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        sortedList.Add(right[rightIndex]);
                        rightIndex++;
                    }
                }
                return sortedList;
            }
        }
    }
}
