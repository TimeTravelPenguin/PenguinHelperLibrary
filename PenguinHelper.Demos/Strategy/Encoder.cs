#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: Encoder.cs
// 
// Current Data:
// 2019-12-30 11:10 PM
// 
// Creation Date:
// 2019-12-30 11:02 PM

#endregion

using PenguinHelperLibrary.Generic_Strategy;

namespace PenguinHelperLibrary.Demos.Strategy
{
  internal class Encoder
  {
    private readonly Strategizer<IEncoder> _strategizer;

    public Encoder()
    {
      _strategizer = new Strategizer<IEncoder>();
    }

    public static string Encode(string message, IEncoder encoder)
    {
      return encoder.Encode(message);
    }
  }
}