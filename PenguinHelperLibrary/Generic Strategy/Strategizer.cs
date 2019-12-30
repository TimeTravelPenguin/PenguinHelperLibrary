#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: Strategizer.cs
// 
// Current Data:
// 2019-12-30 11:28 PM
// 
// Creation Date:
// 2019-12-30 10:34 PM

#endregion

using System;

namespace PenguinHelperLibrary.Generic_Strategy
{
  /// <summary>
  ///   Object used to implement the strategy pattern
  /// </summary>
  /// <typeparam name="T">
  ///   A class object that inherits from <see cref="IStrategy" />.
  /// </typeparam>
  public class Strategizer<T> where T : class, IStrategy
  {
    /// <summary>
    ///   Executes a given strategy.
    /// </summary>
    /// <param name="strategy">
    ///   The strategy to use.
    /// </param>
    /// <param name="parameter">
    ///   The parameter to pass.
    /// </param>
    public void Execute(T strategy, object parameter)
    {
      if (strategy == null)
      {
        throw new ArgumentNullException(nameof(strategy));
      }

      strategy.Execute(parameter);
    }
  }
}