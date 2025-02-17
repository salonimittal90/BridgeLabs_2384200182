using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_s_Runtime_Analysis___Big_O_Notation
{
    internal class SearchTarget
    {
        public void LinearSearch(int[] arr, int target)
        {
            for (int i =0; i < arr.Length; i++)
            {
                if (arr[i]==target)
                {
                    Console.WriteLine(target +" is found at position "+i);
                    return;
                }
            }
            Console.WriteLine(target+" is not found");
        }


        public static bool IsSorted(int[]arr)
        {
            for(int i=0; i<arr.Length-1; i++)
            {
                if (arr[i] > arr[i+1])
                {
                    return false;
                }
               
            }
            return true;
        }
        public void BinarySearch(int[] arr, int target)
        {
            if(!IsSorted(arr))
            {
                Console.WriteLine("Error: Array is not sorted.");
                return;
            }

            int start = 0; int end = arr.Length - 1;
           
              while(start<=end)
              {

                int mid = start + (end - start) / 2;

                if (arr[mid]==target)
              {
              Console.WriteLine(target + " is found");
                    return;
              }
                    
              if(arr[mid]<target)
              {
                    start = mid + 1;
                    

              }
              else
              {
                    end = mid - 1;
                }


              }
            Console.WriteLine("target not found");
            

        }

    }


}
