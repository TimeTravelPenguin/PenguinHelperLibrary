#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: MathExtensions.cs
// 
// Current Data:
// 2019-12-08 1:59 AM
// 
// Creation Date:
// 2019-12-07 6:22 PM

#endregion

using System;
using PenguinHelperLibrary.Objects;

namespace PenguinHelperLibrary.Extension_Methods
{
    /// <summary>
    ///     Extension methods performing <see cref="Math" /> operations.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        ///     Gets the distance between two <see cref="Point2D" />, as per the Pythagorean Theorem,
        /// </summary>
        /// <param name="thisPoint" />
        /// <param name="point" />
        /// <returns>
        ///     Returns the distance between the points.
        /// </returns>
        public static double SqrDistance(this Point2D thisPoint, Point2D point)
        {
            var lhs = Math.Pow(Math.Abs(thisPoint.X - point.X), 2);
            var rhs = Math.Pow(Math.Abs(thisPoint.Y - point.Y), 2);
            return Math.Sqrt(lhs + rhs);
        }

        /// <summary>
        ///     Adds together two <see cref="Vector2D" />.
        /// </summary>
        /// <param name="thisVector2D" />
        /// <param name="vector" />
        /// <returns>
        ///     Returns the sum of two <see cref="Vector2D" />.
        /// </returns>
        public static Vector2D AddVector2D(this Vector2D thisVector2D, Vector2D vector)
        {
            return new Vector2D(thisVector2D.X + vector.X, thisVector2D.Y + vector.Y);
        }

        /// <summary>
        ///     Returns the angle of the line bisecting two <see cref="Point2D" />.
        /// </summary>
        /// <param name="thisPoint" />
        /// <param name="point" />
        /// <param name="returnType">
        ///     The <see cref="Angle" /> to return. Default is <see cref="Angle.Radians" />.
        /// </param>
        /// <returns>
        ///     Returns the angle made by the two <see cref="Point2D" />.
        /// </returns>
        public static double ATan(this Point2D thisPoint, Point2D point, Angle returnType = Angle.Radians)
        {
            var y = thisPoint.Y - point.Y;
            var x = thisPoint.X - point.X;

            var theta = Math.Atan2(y, x);

            return returnType switch
            {
                Angle.Radians => theta,
                Angle.Degrees => theta * 180 / Math.PI,
                _ => throw new InvalidOperationException(nameof(returnType))
            };
        }
    }
}