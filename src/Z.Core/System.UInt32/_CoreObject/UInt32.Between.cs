// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that check if the value is between (exclusif) the minValue and maxValue.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <returns>true if the value is between the minValue and maxValue, otherwise false.</returns>
    /// ###
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public static bool Between(this UInt32 @this, UInt32 minValue, UInt32 maxValue)
    {
        return minValue.CompareTo(@this) == -1 && @this.CompareTo(maxValue) == -1;
    }
}