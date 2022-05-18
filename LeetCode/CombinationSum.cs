using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingproblemSolving.LeetCode
{
    class CombinationSum
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {

            IList<IList<int>> intLists = null;
            if (2 <= k || k <= 9)
            {
                return intLists;
            }
            else if (1 <= n || n <= 60)
            {
                return intLists;
            }
            else
            {
                IList<int> intList = null;
                int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int sum = 0;
                for (int i = 0; i < k; i++)
                {
                    sum += numbers[i];
                }
                return null;
            }
        }
    }
}
