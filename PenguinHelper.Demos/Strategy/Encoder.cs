#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Demos
// File Name: Encoder.cs
// 
// Current Data:
// 2021-07-22 7:56 PM
// 
// Creation Date:
// 2020-04-25 1:29 PM

#endregion

#region usings


#endregion

using PenguinHelper.Patterns.GenericStrategy;

namespace PenguinHelper.Demos.Strategy
{
  internal class Encoder
  {
    private readonly GenericStrategyExecutor<IEncoder> _strategyExecutor;

    public Encoder()
    {
      _strategyExecutor = new GenericStrategyExecutor<IEncoder>();
    }

    public static string Encode(string message, IEncoder encoder)
    {
      return encoder.Encode(message);
    }
  }
}