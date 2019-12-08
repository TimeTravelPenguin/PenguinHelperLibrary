#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: Vector2DDemos.cs
// 
// Current Data:
// 2019-12-09 1:40 AM
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

        internal static void Test()
        {
            var vector1 = new Vector(5);
            var vector2 = new Vector(5);

            vector1.UpdateCoordinate(new double[] {1, 2, 3, 4, 5});
            vector2.UpdateCoordinate(new double[] {10, 10, 10, 10, 10});

            Console.WriteLine(vector1 * vector2);
        }

        public static void AngleDemo()
        {
            var v = new Vector2D(-1, 0);
            Console.WriteLine(v.Theta(Angle.Radians));
            Console.WriteLine(v.Theta(Angle.Degrees));
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