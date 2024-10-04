using System.Drawing;
using System;

namespace Stack_Heap_Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* InsertArray methodu yaradılır.Method parametr olaraq int tipindən array və params olaraq int-lər qəbul edir.
                 Paramslardan gələn dəyərləri həmin arraya əlavə etsin və sonda dəyişilmiş hal köhnə arraya bərabər olsun.
                 (Array resize istifade etmirsiz ozunuz Custom yazirsiz)*/

            int[] arr = { 1, 2, 3, 4, 5, };
            foreach (int i in InsertArray(arr, 6, 7, 8))
            {
                Console.WriteLine(i);
            }

            int[] InsertArray(int[]ar , params int[] values)
            {
                int count = 0;
                int[] newArr = new int[ar.Length + values.Length];

                for(int i = 0; i <= ar.Length + values.Length-1; i++)
                {
                    if (i <= ar.Length-1)
                    {
                        newArr[i] = ar[i];
                    }
                    else
                    {  
                        for (int j = count; j <= values.Length - 1; j++)
                        {
                            count++;
                            newArr[i] = values[j];
                            break;
                        }

                    }
                }
                
                ar = newArr;

               


                return ar;
            }
        }
    }
}