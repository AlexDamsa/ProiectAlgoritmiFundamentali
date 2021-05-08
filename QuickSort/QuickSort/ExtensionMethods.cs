using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public static class ExtensionMethods
    {
        public static void Print<T>(this T[] instance)
        {
            foreach (var x in instance)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instance"></param>
        /// <param name="start">Starting index</param>
        /// <param name="end">Ending index</param>
        public static void QuickSort(this int[] instance, int start, int end)
        {
            if (start > end)
            {
                return;
            }

            if (start < end) 
            {
                int partitionIndex = Partition(start, end);

                instance.QuickSort(start, partitionIndex - 1);
                instance.QuickSort(partitionIndex + 1, end);
            }

            int Partition(int left, int right)
            {
                if (left + 1 == right)                              //    In cazul in care in partitia
                {                                                   //    curent se gasesc doar doua numere,
                    if (instance[left] > instance[right])           //    sunt comparate cele dou numere
                    {                                               //    fara a se executa restul codului
                        Swap(left, right);                          //    
                        return left;                                //
                    }                                               //
                    return right;                                   //
                }                                                   //      

                int pivot = instance[right];                        //    pivotul cu care se comapra elementele din partitia curenta

                int low = left;                                     //    indexul elementelor din partea stanga a pivotului mai mari decat acesta
                int high = right - 1;                               //    indexul elementelor din partea dreapta a pivotului mai mici decat acesta

                while (low < high)                                  //    loop ul se executa cat timp indexul elementelor din partea stanga este mai mic decat indexul elementelor din partea dreapta
                {
                    while (instance[low] <= pivot && low <= high)   //    Cauta urmatorul numar din partea
                    {                                               //    stanga a pivotului mai mare decat pivotul
                        low++;                                      //    cat timp indexul din stanga este mai mic decat
                    }                                               //    cel din dreapta
                    while (instance[high] > pivot && low < high)    //    Cauta urmatorul numar din partea
                    {                                               //    dreapta a pivotului mai mic decat pivotul
                        low++;                                      //    cat timp indexul din stanga este mai mic decat
                    }                                               //    cel din dreapta
                    {
                        high--;
                    }
                    if (low < high)                                 //    Daca indexul din stanga este mai
                    {                                               //    mic decat cel din dreapta,
                        Swap(low, high);                            //    cele doua numere se interschimba
                    }                                               //
                }
                Swap(low, right);                                   //    Pivotul este plasat in locul potrivit
                return low;                                         //    in array si se returneaza indexul acestuia


                void Swap(int index1, int index2)
                {
                    int temp = instance[index1];
                    instance[index1] = instance[index2];
                    instance[index2] = temp;
                }
            }
        }
    }
}
