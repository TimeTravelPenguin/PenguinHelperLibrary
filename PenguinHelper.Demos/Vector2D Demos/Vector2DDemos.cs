﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: Vector2DDemos.cs
// 
// Current Data:
// 2019-12-08 12:59 AM
// 
// Creation Date:
// 2019-12-07 8:09 PM

#endregion

using System;
using PenguinHelperLibrary.Extension_Methods;
using PenguinHelperLibrary.Objects;

namespace PenguinHelperLibrary.Demos.Vector2D_Demos
{
    /// <summary>
    ///     Demo examples for <see cref="Vector2D" />.
    /// </summary>
    public static class Vector2DDemos
    {
        /// <summary>
        ///     Demo of basic <see cref="VectorAddition" />.
        /// </summary>
        public static void VectorAddition()
        {
            var one = Vector2D.One;
            var two = new Vector2D(2, 2);

            var three = one.AddVector2D(two);

            Console.WriteLine("This is an example of Vector addition");
            Console.WriteLine($"Vector A:\tX: {one.X}\t{one.Y}");
            Console.WriteLine($"Vector B:\tX: {two.X}\t{two.Y}");
            Console.WriteLine();
            Console.WriteLine($"A+B:\t\tX: {three.X}\t{three.Y}");
        }

        /// <summary>
        ///     Demo of basic <see cref="DotProduct" />, using operator overloading.
        /// </summary>
        public static void DotProduct()
        {
            var one = Vector2D.One;
            var two = new Vector2D(2, 2);

            var three = one * two;

            Console.WriteLine("This is an example of dot product");
            Console.WriteLine($"Vector A:\tX: {one.X}\t{one.Y}");
            Console.WriteLine($"Vector B:\tX: {two.X}\t{two.Y}");
            Console.WriteLine();
            Console.WriteLine($"A*B:\t\tX: {three}");
        }
    }
}