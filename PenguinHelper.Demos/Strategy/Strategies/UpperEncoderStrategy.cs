#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: UpperEncoderStrategy.cs
// 
// Current Data:
// 2019-12-30 11:14 PM
// 
// Creation Date:
// 2019-12-30 10:57 PM

#endregion

using System;

namespace PenguinHelperLibrary.Demos.Strategy.Strategies
{
  internal class UpperEncoderStrategy : IEncoder
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

      _value = message.ToUpper();
    }
  }
}