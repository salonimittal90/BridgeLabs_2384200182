using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submission_of_Linear_and_Binary_Search
{
    class SortedMatrix
    {

        public static bool SearchMatrix(int[,] matrix, int target, out int row, out int col)
        {
            int m = matrix.GetLength(0); // Number of rows
            int n = matrix.GetLength(1); // Number of columns

            int left = 0, right = (m * n) - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midElement = matrix[mid / n, mid % n];  // Convert 1D index to 2D

                if (midElement == target)
                {
                    row = mid / n;
                    col = mid % n;
                    return true;
                }
                else if (midElement < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            row = -1;
            col = -1;
            return false;  // Not found
        }
    }

}