#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: IFactory.cs
// 
// Current Data:
// 2019-12-30 4:40 PM
// 
// Creation Date:
// 2019-12-30 4:40 PM

#endregion

using System;

namespace PenguinHelperLibrary.Generic_Factory
{
  internal interface IFactory<T> where T : class
  {
    T Create(string key);
    void Register(string key, Func<T> valueFunc);
  }
}