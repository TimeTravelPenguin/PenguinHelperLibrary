#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: Vector.cs
// 
// Current Data:
// 2019-12-09 1:40 AM
// 
// Creation Date:
// 2019-12-09 12:29 AM

#endregion

using System;
using System.Linq;

namespace PenguinHelperLibrary.Objects
{
    public class Vector
    {
        private Point[] _coordinate;
        private int _dimensions;

        public int Dimensions
        {
            get => _dimensions;
            set => UpdateDimensionValue(value);
        }

        public Point[] Coordinate
        {
            get => _coordinate;
            set => UpdateCoordinateReference(value);
        }

        public Vector(int dimensions)
        {
            if (dimensions < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(dimensions), "Dimensions cannot be less than zero.");
            }

            _dimensions = dimensions;
            _coordinate = new Point[_dimensions];

            for (var i = 0; i < _coordinate.Length; i++)
            {
                _coordinate[i] = new Point();
            }
        }

        public void UpdateCoordinateReference(Point[] value)
        {
            if (value == null)
            {
                throw new NullReferenceException(nameof(value));
            }

            if (value.Length != _dimensions)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    "The passed value does not have the same number of dimensions as this object");
            }

            _coordinate = value;
        }

        public void UpdateCoordinate(double[] values)
        {
            if (values == null)
            {
                throw new NullReferenceException(nameof(values));
            }

            if (values.Length != _dimensions)
            {
                throw new ArgumentOutOfRangeException(nameof(values),
                    "The passed values does not have the same number of dimensions as this object");
            }

            for (var i = 0; i < _dimensions; i++)
            {
                _coordinate[i].Value = values[i];
            }
        }

        private void UpdateDimensionValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Dimensions cannot be less than zero.");
            }

            _dimensions = value;
            Array.Resize(ref _coordinate, value);

            for (var i = 0; i < _coordinate.Length; i++)
            {
                if (_coordinate[i] == null)
                {
                    _coordinate[i] = new Point();
                }
            }
        }

        /// <summary>
        ///     <see cref="Vector" /> dot product operator.
        /// </summary>
        /// <param name="vectorLhs" />
        /// <param name="vectorRhs" />
        /// <returns>
        ///     Returns the dot product of two <see cref="Vector" />.
        /// </returns>
        public static double operator *(Vector vectorLhs, Vector vectorRhs)
        {
            if (vectorLhs == null || vectorRhs == null)
            {
                throw new NullReferenceException();
            }

            if (vectorLhs._coordinate.Contains(null) || vectorRhs._coordinate.Contains(null))
            {
                throw new NullReferenceException();
            }

            if (vectorLhs._dimensions != vectorRhs._dimensions)
            {
                throw new ArgumentOutOfRangeException(nameof(vectorLhs), nameof(vectorRhs),
                    "Vectors must has the same value dimension");
            }

            double dot = 0;
            for (var i = 0; i < vectorLhs.Dimensions; i++)
            {
                dot += vectorLhs._coordinate[i].Value * vectorRhs._coordinate[i].Value;
            }

            return dot;
        }
    }
}