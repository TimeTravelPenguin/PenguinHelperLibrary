#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: Program.cs
// 
// Current Data:
// 2019-12-08 12:45 AM
// 
// Creation Date:
// 2019-12-07 8:08 PM

#endregion

using System;
using PenguinHelperLibrary.Demos.Vector2D_Demos;

namespace PenguinHelperLibrary.Demos
{
    /// <summary>
    ///     Main entry point for <see cref="PenguinHelperLibrary.Demos" />
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     Main method launches the desired demo
        /// </summary>
        public static void Main()
        {
            Vector2DDemos.Test();

            Console.ReadKey();
        }
    }
}