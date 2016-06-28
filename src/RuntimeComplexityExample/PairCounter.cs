using System.Linq;

namespace RuntimeComplexityExample
{
    public class PairCounter
    {
        // Original Function runtime complexity O(n*n) -squared. Doing the little 2 in a .cs file is bleh.

        // Bug 1) Function was not public so the function could not be reached from outside the class. This wouldn't necessary be a problem except that this is the only function in the class so having a class with a private function is a bit odd.

        // Bug 2) Changed the name of the function to match C# naming conventions and changed the class name since they can't be the same. Since I'm doing this in my native language, I'm going to be picky.

        // Bug 3) The declaration of int a was wrong. The code: int a[] is invalid.
        public static int CountPairs(int[] a, int x)
        {
            var count = 0;

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < a.Length; j++)
                {
                    // Bug 4) This wouldn't have worked right because the if was comparing the loop cursors and not the actual values from the array.
                    if (a[i] + a[j] == x)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        //New algorithm should be O(n)
        public static int CountPairsNew(int[] a, int x)
        {
            return a.Intersect(a.Select(y => x - y)).Count();
        }
    }
}
