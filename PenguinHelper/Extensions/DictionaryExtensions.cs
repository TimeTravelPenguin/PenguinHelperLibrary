#region Title Header

// Name: Phillip Smith
// 
// Solution: PenguinHelperLibrary
// Project: PenguinHelper
// File Name: DictionaryExtensions.cs
// 
// Current Data:
// 2021-07-22 8:19 PM
// 
// Creation Date:
// 2021-07-22 7:18 PM

#endregion

#region usings

using System;
using System.Collections;
using System.Collections.Generic;

#endregion

namespace PenguinHelper.Extensions
{
  /// <summary>
  ///   Extension methods for type <see cref="IDictionary" />
  /// </summary>
  public static class DictionaryExtensions
  {
    /// <summary>
    ///   Returns a <typeparamref name="TValue" /> within an <see cref="IDictionary{TKey,TValue}" />, given a
    ///   <typeparamref name="TKey" /> <paramref name="key" />. If the <typeparamref name="TKey" /> does not exist, the
    ///   returned value is the <see langword="default" /> value of <typeparamref name="TValue" />.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary">The <see cref="IDictionary" /> value to get a value.</param>
    /// <param name="key">
    ///   The <typeparamref name="TKey" /> key value of a <see cref="KeyValuePair{TKey,TValue}" /> within
    ///   <paramref name="dictionary" />.
    /// </param>
    /// <returns>
    ///   Returns a <typeparamref name="TValue" /> value paired with <paramref name="key" />, if <paramref name="key" />
    ///   exists. Otherwise, returns the default type of <typeparamref name="TValue" />.
    /// </returns>
    public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
    {
      if (dictionary is null)
      {
        throw new ArgumentNullException(nameof(dictionary));
      }

      return dictionary.TryGetValue(key, out var result)
        ? result
        : default;
    }

    /// <summary>
    ///   Returns a <typeparamref name="TValue" /> within an <see cref="IDictionary{TKey,TValue}" />, given a
    ///   <typeparamref name="TKey" /> <paramref name="key" />. If the <typeparamref name="TKey" /> does not exist, the
    ///   returned value is <paramref name="defaultValue" />.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary">The <see cref="IDictionary" /> value to get a value.</param>
    /// <param name="key">
    ///   The <typeparamref name="TKey" /> key value of a <see cref="KeyValuePair{TKey,TValue}" /> within
    ///   <paramref name="dictionary" />.
    /// </param>
    /// <param name="defaultValue">
    ///   The <typeparamref name="TValue" /> to return if the <see cref="IDictionary" /> does not contain the
    ///   <typeparamref name="TKey" /> name="TKey" /> <paramref name="key" />.
    /// </param>
    /// <returns>
    ///   Returns a <typeparamref name="TValue" /> value paired with <paramref name="key" />, if <paramref name="key" />
    ///   exists. Otherwise, returns <paramref name="defaultValue" />.
    /// </returns>
    public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key,
      TValue defaultValue)
    {
      if (dictionary is null)
      {
        throw new ArgumentNullException(nameof(dictionary));
      }

      return dictionary.TryGetValue(key, out var result)
        ? result
        : defaultValue;
    }

    /// <summary>
    ///   Adds a array of <see cref="KeyValuePair{TKey,TValue}" /> to an <see cref="IDictionary{Tkey, TValue}" />.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary">
    ///   The <see cref="IDictionary{TKey,TValue}" /> to add to.
    /// </param>
    /// <param name="keyValuePair">
    ///   The <see cref="KeyValuePair{TKey,TValue}" /> to add.
    /// </param>
    public static void Add<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
      KeyValuePair<TKey, TValue> keyValuePair)
    {
      if (dictionary is null)
      {
        throw new ArgumentNullException(nameof(dictionary));
      }

      dictionary.Add(keyValuePair);
    }

    /// <summary>
    ///   Adds a array of <see cref="KeyValuePair{TKey,TValue}" /> to an <see cref="IDictionary{Tkey, TValue}" />.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dictionary">
    ///   The <see cref="IDictionary{TKey,TValue}" /> to add to.
    /// </param>
    /// <param name="keyValuePairs">
    ///   The array of <see cref="KeyValuePair{TKey,TValue}" /> to add.
    /// </param>
    public static void AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dictionary,
      IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs)
    {
      if (dictionary is null)
      {
        throw new ArgumentNullException(nameof(dictionary));
      }

      if (keyValuePairs is null)
      {
        throw new ArgumentNullException(nameof(keyValuePairs));
      }

      foreach (var (key, value) in keyValuePairs)
      {
        dictionary.Add(key, value);
      }
    }
  }
}