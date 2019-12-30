#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary.Demos
// File Name: IEncoder.cs
// 
// Current Data:
// 2019-12-30 11:09 PM
// 
// Creation Date:
// 2019-12-30 11:05 PM

#endregion

using PenguinHelperLibrary.Generic_Strategy;

namespace PenguinHelperLibrary.Demos.Strategy
{
  internal interface IEncoder : IStrategy
  {
    string Encode(string message);
  }
}