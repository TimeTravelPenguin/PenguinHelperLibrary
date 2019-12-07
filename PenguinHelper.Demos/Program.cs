#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Demos
// File Name: Program.cs
// 
// Current Data:
// 2019-12-07 8:28 PM
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
    internal static class Program
    {
        /// <summary>
        ///     Main method launches the desired demo
        /// </summary>
        private static void Main()
        {
            Vector2DDemos.DotProduct();

            Console.ReadKey();
        }
    }
}