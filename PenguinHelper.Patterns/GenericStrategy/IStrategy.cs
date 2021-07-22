#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: IStrategy.cs
// 
// Current Data:
// 2019-12-30 11:31 PM
// 
// Creation Date:
// 2019-12-30 10:48 PM

#endregion

namespace PenguinHelper.Patterns.GenericStrategy
{
  /// <summary>
  ///   Interface for a strategy
  /// </summary>
  public interface IStrategy
  {
    /// <summary>
    ///   Executes the strategy
    /// </summary>
    /// <param name="parameter">
    ///   A passed parameter to the strategy.
    /// </param>
    void Execute(object parameter);
  }
}