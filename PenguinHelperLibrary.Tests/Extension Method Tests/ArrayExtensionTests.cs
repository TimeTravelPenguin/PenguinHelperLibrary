#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Tests
// File Name: ArrayExtensionTests.cs
// 
// Current Data:
// 2019-12-30 7:10 PM
// 
// Creation Date:
// 2019-12-30 6:38 PM

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using AllOverIt.Fixture;
using FluentAssertions;
using JetBrains.Annotations;
using PenguinHelperLibrary.Extension_Methods;
using PenguinHelperLibrary.Generic_Factory;
using Xunit;

namespace PenguinHelperLibrary.Tests.Extension_Method_Tests
{
  /// <summary>
  ///   Tests for <see cref="ArrayExtensionMethods" />
  /// </summary>
  [UsedImplicitly]
  public class ArrayExtensionTests
  {
    /// <summary>
    ///   Tests <see cref="ArrayExtensionMethods.Fill{T}(T[], T)" />
    /// </summary>
    public class FillTests : AoiFixtureBase
    {
      /// <summary>
      ///   Tests filling value for all indexes of array
      /// </summary>
      [Fact]
      public void FillTest()
      {
        var fillValue = Create<decimal>();
        var actual = new decimal[10];

        actual.Fill(fillValue);

        foreach (var value in actual)
        {
          value
            .Should()
            .Be(fillValue);
        }
      }

      /// <summary>
      ///   Tests that method throws exception when array is null
      /// </summary>
      [Fact]
      public void FillTest_NullArray()
      {
        Invoking(() => ((decimal[]) null).Fill(Create<decimal>()))
          .Should()
          .ThrowExactly<ArgumentNullException>();
      }

      /// <summary>
      ///   Tests filling with object is same object reference for all values
      /// </summary>
      [Fact]
      public void FillTest_WithObject()
      {
        var fillValue = new object();
        var actual = new object[10];

        actual.Fill(fillValue);

        foreach (var value in actual)
        {
          value
            .Should()
            .BeSameAs(fillValue);
        }
      }
    }

    /// <summary>
    ///   Tests <see cref="ArrayExtensionMethods.FillWithDefault{T}(T[])" />
    /// </summary>
    public class FillWithDefaultTests : AoiFixtureBase
    {
      /// <summary>
      ///   Tests all indexes hold the default value of the given array type
      /// </summary>
      [Fact]
      public void FillWithDefaultTest()
      {
        const int arrLength = 10;

        var arrDec = new decimal[arrLength];
        var arrStr = new string [arrLength];
        var arrObj = new object[arrLength];


        arrDec.FillWithDefault();
        arrStr.FillWithDefault();
        arrObj.FillWithDefault();

        for (var i = 0; i < arrLength; i++)
        {
          arrDec[i].Should().Be(default);
          arrStr[i].Should().Be(default);
          arrObj[i].Should().Be(default);
        }
      }
    }

    /// <summary>
    ///   Tests for <see cref="ArrayExtensionMethods.FillNullIndex{T}(T[], T)" />
    /// </summary>
    public class FillNullIndexTests : AoiFixtureBase
    {
      /// <summary>
      ///   Tests that all null values are replaced
      /// </summary>
      [Fact]
      public void FillIfNullTest()
      {
        var random = new Random();

        object GetNewObject()
        {
          return random.Next(2) == 0 ? new object() : null;
        }

        var array = new object[100];

        do
        {
          for (var i = 0; i < array.Length; i++)
          {
            array[i] = GetNewObject();
          }
        } while (!array.Contains(null));

        array.FillNullIndex(new object());

        // Test that there are no null values
        array
          .Should()
          .NotContainNulls();
      }

      /// <summary>
      ///   Tests for null argument exception
      /// </summary>
      [Fact]
      public void FillIfNullTest_ArgumentNullException()
      {
        Invoking(() => ((object[]) null).FillNullIndex(new object()))
          .Should()
          .ThrowExactly<ArgumentNullException>();
      }
    }

    /// <summary>
    ///   Tests for <see cref="ArrayExtensionMethods.Fill{T}(T[], Func{T})" />.
    /// </summary>
    public class FillUsingFactory : AoiFixtureBase
    {
      private class DemoFactory : FactoryBase<DemoFactory.IDemo>
      {
        public DemoFactory()
        {
          Registry = new Dictionary<string, Func<IDemo>>
          {
            ["Demo"] = () => new DemoObject()
          };
        }

        public interface IDemo
        {
        }

        public class DemoObject : IDemo
        {
        }
      }

      /// <summary>
      ///   Uses the fill function to add objects using a factory
      /// </summary>
      [Fact]
      public void FillUsingFactoryTest()
      {
        var factory = new DemoFactory();

        DemoFactory.IDemo FillValue()
        {
          return factory.Create("Demo");
        }

        var actual = new DemoFactory.IDemo[10];

        actual.Fill(FillValue);

        foreach (var value in actual)
        {
          value
            .Should()
            .BeAssignableTo<DemoFactory.IDemo>()
            .And
            .BeOfType<DemoFactory.DemoObject>();
        }
      }
    }
  }
}