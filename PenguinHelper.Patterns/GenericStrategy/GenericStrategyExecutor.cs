#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper
// File Name: GenericStrategyExecutor.cs
// 
// Current Data:
// 2021-07-22 7:48 PM
// 
// Creation Date:
// 2021-07-22 7:18 PM

#endregion

#region usings

using System;

#endregion

namespace PenguinHelper.Patterns.GenericStrategy
{
  /// <summary>
  ///   Object used to implement the strategy pattern
  /// </summary>
  /// <typeparam name="T">
  ///   A class object that inherits from <see cref="IStrategy" />.
  /// </typeparam>
  public class GenericStrategyExecutor<T> where T : class, IStrategy
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