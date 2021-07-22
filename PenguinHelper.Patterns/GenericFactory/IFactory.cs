#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelperLibrary
// File Name: IFactory.cs
// 
// Current Data:
// 2019-12-30 6:32 PM
// 
// Creation Date:
// 2019-12-30 6:17 PM

#endregion

using System;

namespace PenguinHelper.Patterns.GenericFactory
{
  /// <summary>
  ///   Interface for generic factory.
  /// </summary>
  /// <typeparam name="T">
  ///   The type of object factory creates.
  /// </typeparam>
  public interface IFactory<T> where T : class
  {
    /// <summary>
    ///   Create a new object, given by <paramref name="key" />.
    /// </summary>
    /// <param name="key">
    ///   The key given to create an object.
    /// </param>
    /// <returns>
    ///   Returns object of type <typeparamref name="T" />.
    /// </returns>
    T Create(string key);

    /// <summary>
    ///   Registers a new object to the factory registry so that the factory can then create a new object that didn't
    ///   previously exist within the registry.
    /// </summary>
    /// <param name="key">
    ///   The key to be assigned to the registry.
    /// </param>
    /// <param name="valueFunc">
    ///   The <see cref="Func{T1}" /> to generate a new object for <paramref name="key" />.
    /// </param>
    void Register(string key, Func<T> valueFunc);
  }
}