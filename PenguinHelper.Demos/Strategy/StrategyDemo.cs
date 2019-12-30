#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: StrategyDemo.cs
// 
// Current Data:
// 2019-12-30 11:17 PM
// 
// Creation Date:
// 2019-12-30 10:55 PM

#endregion

using System;
using PenguinHelperLibrary.Demos.Strategy.Strategies;

namespace PenguinHelperLibrary.Demos.Strategy
{
  internal static class StrategyDemo
  {
    public static void RunDemo()
    {
      const string message = "Hello there! Penguins are pretty COOL!";

      // create strategies
      var upperEncoder = new UpperEncoderStrategy();
      var lowerEncoder = new LowerEncoderStrategy();

      // create strategy user
      var encoder = new Encoder();

      // combine
      var upperMessage = Encoder.Encode(message, upperEncoder);
      var lowerMessage = Encoder.Encode(message, lowerEncoder);

      Console.WriteLine("Original:\t" + message);
      Console.WriteLine("Upper:\t\t" + upperMessage);
      Console.WriteLine("Lower:\t\t" + lowerMessage);
    }
  }
}