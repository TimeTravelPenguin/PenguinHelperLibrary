#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Demos
// File Name: LowerEncoderStrategy.cs
// 
// Current Data:
// 2021-07-22 7:56 PM
// 
// Creation Date:
// 2020-04-25 1:30 PM

#endregion

#region usings

using System;

#endregion

namespace PenguinHelper.Demos.Strategy.Strategies
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
      if (parameter is not string message)
      {
        throw new ArgumentException("Parameter is not a string", nameof(parameter));
      }

      _value = message.ToLower();
    }
  }
}