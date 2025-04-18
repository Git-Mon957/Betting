namespace BettingSystem.Infrastructure.Common.Extensions;

using System;
using System.Collections.Generic;

public static class EnumerableExtensions
{
    public static void ForEach<T>(
        this IEnumerable<T> enumerable,
    {
        foreach (var item in enumerable)
        {
            action(item);
        }
    }
}