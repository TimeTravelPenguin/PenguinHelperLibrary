using System;

namespace PenguinHelperLibrary.Extension_Methods
{
    public static class EnumExtensions
    {
        public static T[] EnumArray<T>() where T : Enum
        {
            return (T[]) Enum.GetValues(typeof(T));
        }
    }
}