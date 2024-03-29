﻿#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper
// File Name: FactoryBase.cs
// 
// Current Data:
// 2021-07-22 7:50 PM
// 
// Creation Date:
// 2021-07-22 7:18 PM

#endregion

#region usings

using System;
using System.Collections.Generic;

#endregion

namespace PenguinHelper.Patterns.GenericFactory
{
  /// <summary>
  ///   Creates a Factory to construct objects of type <typeparamref name="T" />.
  /// </summary>
  /// <typeparam name="T">
  ///   A class type object
  /// </typeparam>
  public abstract class FactoryBase<T> : IFactory<T> where T : class
  {
    /// <summary>
    ///   An <see cref="IDictionary{TKey,TValue}" /> containing <see cref="KeyValuePair{TKey,TValue}" /> to create objects.
    /// </summary>
    protected abstract IDictionary<string, Func<T>> Registry { get; }

    /// <summary>
    ///   If <see cref="Registry" /> contains a Key" of <paramref name="key" />,
    ///   it will return an object defined by the Value.
    /// </summary>
    /// <param name="key">
    ///   The Key contained within <see cref="Registry" />.
    /// </param>
    /// <exception cref="ArgumentException">
    ///   Throws exception if <see cref="Registry" /> does not contain Key
    /// </exception>
    /// <returns>
    ///   Returns object of type <typeparamref name="T" />.
    /// </returns>
    public T Create(string key)
    {
      if (Registry.TryGetValue(key, out var returnValue))
      {
        return returnValue.Invoke();
      }

      throw new ArgumentException($"Unknown key '{key}'", nameof(key));
    }

    /// <summary>
    ///   Adds a new pair to <see cref="Registry" /> for creation of new objects of type <typeparamref name="T" />.
    /// </summary>
    /// <param name="key">
    ///   The <see cref="string" /> Key to add to <see cref="Registry" />.
    /// </param>
    /// <param name="valueFunc">
    ///   The <see cref="Func{T}" /> Value to add to <see cref="Registry" />.
    /// </param>
    /// <exception cref="ArgumentException">
    ///   Throws exception if <see cref="Registry" /> already contains Key attempting to be
    ///   registered
    /// </exception>
    public void Register(string key, Func<T> valueFunc)
    {
      if (Registry.ContainsKey(key))
      {
        throw new ArgumentException($"The key '{key}' already exists", nameof(key));
      }

      Registry.Add(key, valueFunc);
    }
  }
}