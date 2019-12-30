#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: Program.cs
// 
// Current Data:
// 2019-12-30 11:13 PM
// 
// Creation Date:
// 2019-12-30 6:17 PM

#endregion

using System;
using PenguinHelperLibrary.Demos.Strategy;

namespace PenguinHelperLibrary.Demos
{
  /// <summary>
  ///   Main entry point for <see cref="PenguinHelperLibrary.Demos" />
  /// </summary>
  public static class Program
  {
    /// <summary>
    ///   Main method launches the desired demo
    /// </summary>
    public static void Main()
    {
      StrategyDemo.RunDemo();
      Console.ReadKey();
    }
  }
}