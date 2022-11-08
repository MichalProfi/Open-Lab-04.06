using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).ToArray();
        }
    }
}
