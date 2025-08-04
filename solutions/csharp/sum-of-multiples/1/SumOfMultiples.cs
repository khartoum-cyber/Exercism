using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max) => 
        Enumerable.Range(0, max)
            .Where(i => multiples.Any(i1 => i1 != 0 && i % i1 == 0))
            .Sum();
}