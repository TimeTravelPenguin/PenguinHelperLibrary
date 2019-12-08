#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: ArrayExtensionMethods.cs
// 
// Current Data:
// 2019-12-09 1:09 AM
// 
// Creation Date:
// 2019-12-09 1:02 AM

#endregion

using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    public static class ArrayExtensionMethods
    {
        public static void Fill<T>(this T[] arr, T value)
        {
            if (arr == null)
            {
                throw new NullReferenceException(nameof(arr));
            }

            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = value;
            }
        }

        public static void FillIfNull<T>(this T[] arr, T value)
        {
            if (arr == null)
            {
                throw new NullReferenceException(nameof(arr));
            }

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = value;
                }
            }
        }
    }
}