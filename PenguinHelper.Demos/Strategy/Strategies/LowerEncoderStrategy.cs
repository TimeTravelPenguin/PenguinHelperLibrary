#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: LowerEncoderStrategy.cs
// 
// Current Data:
// 2019-12-30 11:15 PM
// 
// Creation Date:
// 2019-12-30 11:01 PM

#endregion

using System;

namespace PenguinHelperLibrary.Demos.Strategy.Strategies
{
  internal class LowerEncoderStrategy : IEncoder
  {
    private string _value;

    public string Encode(string message)
    {
      Execute(message);
      return _value;
    }

    public void Execute(object parameter)
    {
      if (!(parameter is string message))
      {
        throw new ArgumentException("Parameter is not a string", nameof(parameter));
      }

      _value = message.ToLower();
    }
  }
}