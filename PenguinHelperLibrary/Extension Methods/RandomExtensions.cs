#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: RandomExtensions.cs
// 
// Current Data:
// 2019-12-18 12:22 AM
// 
// Creation Date:
// 2019-12-07 3:05 PM

#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods to perform random operations
    /// </summary>
    public static class RandomExtensions
    {
        private static readonly Random Random = new Random();
        private static readonly object SyncLock = new object();

        /// <summary>
        ///     Returns a random item from within an <see cref="ICollection{T}" />.
        /// </summary>
        /// <typeparam name="T">
        ///     The object type of the elements of the collection.
        /// </typeparam>
        /// <param name="collection">
        ///     The collection of elements.
        /// </param>
        /// <returns>
        ///     Returns a random <typeparamref name="T" /> from within <paramref name="collection" />.
        /// </returns>
        public static T GetRandomIn<T>(this ICollection<T> collection)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            return collection.ToArray()[RandInt(0, collection.Count)];
        }

        private static int RandInt(int min, int max)
        {
            lock (SyncLock)
            {
                return Random.Next(min, max);
            }
        }

        private static double RandInRange(double min, double max)
        {
            lock (SyncLock)
            {
                return min + Random.NextDouble() * max;
            }
        }
    }
}