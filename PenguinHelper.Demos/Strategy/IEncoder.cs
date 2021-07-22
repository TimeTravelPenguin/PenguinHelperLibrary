#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper.Demos
// File Name: IEncoder.cs
// 
// Current Data:
// 2021-07-22 7:55 PM
// 
// Creation Date:
// 2020-04-25 1:28 PM

#endregion

#region usings


#endregion

using PenguinHelper.Patterns.GenericStrategy;

namespace PenguinHelper.Demos.Strategy
{
  internal interface IEncoder : IStrategy
  {
    string Encode(string message);
  }
}